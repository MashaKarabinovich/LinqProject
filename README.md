# LinqProject
A project centered around using MVC to create an application and LINQ in order to get information needed from the databases. 

I am currently using Visual Studio 2019 to get most of the code and framework running. 

Here is the problem: 
---

I have an existing database (it's huge with a number of tables), but we're only going to concentrate on a couple for now.

The connection string is: Server=imorders.com; Initial Catalog=IM_Import; Persist Security Info=true;User ID=sa;Password=QpWoEi314!;Connection Timeout=36000

I need you to scaffold the following tables:

1) inventory_items
2) inventory_item_warehouse_details

I'd like you to build a small website/app that will allow me to look up an item by itemnum and use fuzzy search to where if I enter in 480 it would return any item that starts with 480. I only want items with the item_type of 'moulding'.

I'd like you to display the results in a list/grid and when I click on an item, I'd like a details page that displays the description of item as well as price details (chop_price, length_price, assemble_price, unit_price, split_price).

---
