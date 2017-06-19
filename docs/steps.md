# Step By Step Guide

## Create Site See [Create site issue](https://github.com/VBDev2Dev/VBStore/pull/3)
1. Create ASP.Net MVC site  ![Create Site 1](images/Create site 1.png)  ![Create Site 2](images/Create site 2.png)
1. Choose bootstrap theme and update bootstrap files with new css files.  I chose [Cyborg from bootswatch](https://bootswatch.com/cyborg/)

## Setup Migrations
1. Enable migrations.  This will let us use code first migrations. Read about them [here]() ![Roles 1](images/Roles 1.png)
1. Add initial migration. ![Roles 2](images/Roles 2.png)
1. Update web config to have database names desired.

## Setup Roles
1. Add default role seeding to create the roles if needed.
1. Run update-database to apply code migrations and get roles in db.![Roles 3](images/Roles 3.png)
1. Add new users to default role.

## Blog
1. Add Blog Area ![Blog 3](images/Blog 3.png)
1. Add Model for BlogPost.
1. Add EF context for Blog
    1. ![Blog 1](images/Blog 1.png)
    1. ![Blog 2](images/Blog 2.png)
1. Add Migration configuration for Blog context ![Blog 4](images/Blog 4.png)
1. Add Inital migration ![Blog 5](images/Blog 5.png)
1. Add HomeController to Blog Area
    1. ![Blog 6](images/Blog 6.png)
    1. ![Blog 7](images/Blog 7.png)
    1. ![Blog 8](images/Blog 8.png)