# Migrations Guide
Migrations are a way to version your database while keeping it updated when editing the tables from the code.

## One-Time Setup
Using this one-time setup is preferrable to avoid repetitive work.

### Setup Migration
For starters, open the Package Manager CLI:
<br><p align="center">
	<img src="https://user-images.githubusercontent.com/62569931/166803101-0f21900c-f9ea-43d7-9559-c6c8b934ad29.png" width="60%" style="margin-left: auto; margin-right: auto;"/>
</p>

Make sure that the default project is pointed to AnyDexDB, and check that the working directory is the project's folder:
<br><p align="center">
	<img src="https://user-images.githubusercontent.com/62569931/166803640-d09dcda5-b6bb-49d8-93ae-1301b518a6aa.png" width="60%" style="margin-left: auto; margin-right: auto;"/>
</p>

Now enter the following commands in the CLI:
1) Make sure that no migration is currently being tracked:
```
Remove-Migration -Context AnyDexDb
```

2) Create the migration files that handle the database's version:
```
Add-Migration -Context AnyDexDb InitialCreate
```

3) Create the database:
```
Update-Database -Context AnyDexDb
```


### Automation
When an edit is made, it is required to run the Update-Database again.
To make this quicker, you can use Visual Studio to make a script for it:
1) Open the External Tools tab:
<br><p align="center">
	<img src="https://user-images.githubusercontent.com/62569931/166810638-e2b07015-b8f3-4d90-98f5-53a50529dcfd.png" width="50%" style="margin-left: auto; margin-right: auto;"/>
</p>

2) Click the "ADD" button, then fill the fields with the following data:
<br><p align="center">
	<img src="https://user-images.githubusercontent.com/62569931/166811347-34713c1d-f19b-4dbb-80d3-989313ee2425.png" width="50%" style="margin-left: auto; margin-right: auto;"/>
</p>

3) Hit APPLY and close the window.
Now you can run this script after you make changes to the entity classes by clicking here:
<br><p align="center">
	<img src="https://user-images.githubusercontent.com/62569931/166811596-b9e2c877-8486-4d5f-8d4b-03857cc1fdd6.png" width="50%" style="margin-left: auto; margin-right: auto;"/>
</p>

## Migration is not working, what should I do?
The migration may be tracking a version of the database different than the one you have.
1) Drop the database
3) Follow the 3 steps listed on top
