script to create login and user is excluded from this repo.
create a file called create-login.sql (This file is ignored by git ignore in this repo)
add the following script to that file:

use master
create login [loginname] with Password = '[password]'
switch to HeartyHearthDB
create user [username] from login [loginname]