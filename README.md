# MvcBloggy Project

This is an unprofessional blog engine created with ASP.NET MVC. 

#Getting Started
Before cloning this repository, make sure that you have SQL Server Express 2008 R2 (at least) and Visual Studio 2012 installed. If you do, you can run the `.\scripts\build.ps1 -buildTarget /t:initial` to build the project and initialize the database on your windows development environment.

#Git Workflow
`master` branch only holds the latest stable version of the product. Navigate to `dev` branch in order to see latest work.

##Pull Requests &amp; Branching
Every feature must be developed under a so-called feature branch and that branch must be brached off from `dev` branch.

*Pull Requests* should be targeted to `dev` branch, not `master`! Before sending the PR, make sure you have the latest `dev` branch merged into you feature branch.

#License and Copyright
This project licensed under MIT license.