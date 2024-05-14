namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableEnum {Staff, Cuisine, Ingredient, Measurement, Course }
        DataTable dt = new();
        TableEnum currenttable = TableEnum.Staff;
        string deletecolumn = "delete";
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            gData.CellContentClick += GData_CellContentClick;
            BindData(currenttable);
            SetupRadioButtons();
            
            
        }

        

        private void BindData(TableEnum table)
        {
            currenttable = table;
            dt = DataMaintenance.GetDataList(currenttable.ToString());
            gData.Columns.Clear();
            gData.DataSource = dt;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolumn);
            WindowsFormsUtility.FormatGridForEdit(gData, table.ToString());

           
        }
        private void SetupRadioButtons()
        {
            foreach (Control c in pnlRadioButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            rbUsers.Tag = TableEnum.Staff;
            rbCuisines.Tag = TableEnum.Cuisine;
            rbIngredients.Tag = TableEnum.Ingredient;
            rbMeasurements.Tag=TableEnum.Measurement;
            rbCourses.Tag = TableEnum.Course;
            
        }
        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dt, currenttable.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }
        private void C_Click(object? sender, EventArgs e)
        {
            if(sender is Control && ((Control)sender).Tag is TableEnum)
            {
                BindData((TableEnum)((Control)sender).Tag);
            }
        }
        private void Delete(int rowindex)
        {

            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttable.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttable.ToString(), id);
                    BindData(currenttable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }


            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolumn)
            {
                if (currenttable == TableEnum.Staff)
                {
                 var response=   MessageBox.Show("Are you sure you want to delete this user and all related recipes, meals and cookbooks?", Application.ProductName, MessageBoxButtons.YesNo);
                    switch (response)
                    {
                        case DialogResult.No:
                            return;

                        case DialogResult.Yes:

                            Delete(e.RowIndex);
                            BindData(currenttable);

                            break;
                    }
                }
                else
                {
                 var responses=   MessageBox.Show($"Are you sure you want to delete this {currenttable}?", Application.ProductName, MessageBoxButtons.YesNo);
                    switch (responses)
                    {
                        case DialogResult.No:
                            return;

                        case DialogResult.Yes:

                            Delete(e.RowIndex);
                            BindData(currenttable);

                            break;
                    }

                }
               
            }

        }
            

            private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
            {
            if (SQLUtility.TableHasChanges(dt))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b== false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.No:
                        this.Activate();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }

            }
    

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
 

    }
}
