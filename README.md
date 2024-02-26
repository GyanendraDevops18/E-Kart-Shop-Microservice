# E-Kart-Shop-Microservice
E-Kart-Microservice

# I don't see the Blank Solution Template anymore.
Solution:

![image](https://github.com/GyanendraDevops18/E-Kart-Shop-Microservice/assets/40474661/a047f4c1-b8dc-47b6-a759-35579d15e2d5)

# Intact with container - for example, mongo container

Note: Starting from Mongodb version 6.0 mongo was replaced by mongosh

# mongo commands
mongosh
show dbs
use CatalogDb  --> for create db on mongo
db.createCollection('Products')  --> for create people collection

db.Products.insertMany([{ 'Name':'Asus Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':54.93 }, { 'Name':'HP Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':88.93 } ])

db.Products.find({}).pretty()<hr>
db.Products.remove({})<hr>

show databases<hr>
show collections<hr>
db.Products.find({}).pretty()

