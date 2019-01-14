# InventoryManagement
Inventory Management System

Sample project with login screen and GridView component for add/delete rows into db.

Table query:
<pre><code>
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[ProductStatus] [bit] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED)
</pre></code>
