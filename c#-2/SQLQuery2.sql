/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [categoryId]
      ,[categoryName]
      ,[description]
  FROM [demodb].[dbo].[Categories]
  select categoryId from Categories;