create database MyShop;

use MyShop;

create table suppliers
(
    id            int          not null auto_increment,
    supplier_name varchar(100) not null,
    city          varchar(100) not null,
    country       varchar(100) not null,
    primary key (id)
);

create table categories
(
    id            int          not null auto_increment,
    category_name varchar(100) not null,
    description   varchar(255) not null,
    primary key (id)
);

create table products
(
    id           int          not null auto_increment,
    product_name varchar(100) not null,
    supplier_id  int          not null,
    category_id  int          not null,
    price        double       not null,
    primary key (id),
    foreign key (supplier_id) references suppliers (id),
    foreign key (category_id) references categories (id)
);

insert into suppliers(id, supplier_name, city, country)
values (1, 'Exotic Liquid', 'London', 'UK'),
       (2, 'New Orleans Cajun Delights', 'New Orleans', 'USA'),
       (3, 'Grandma Kelly\'s Homestead', 'Ann Arbor', 'USA'),
       (4, 'Tokyo Traders', 'Tokyo', 'Japan'),
       (5, 'Cooperativa de Quesos \'Las Cabras\'', 'Quiedo', 'Spain');

insert into categories(id, category_name, description)
values (1, 'Beverages', 'Soft drinks, coffees, teas, beers, and ales'),
       (2, 'Condiments', 'Sweet and savory sauces, relishes, spreads, and seasonings'),
       (3, 'Confections', 'Desserts, candies, and sweet breads'),
       (4, 'Dairy Products', 'Cheeses, milk, eggs, and alternatives'),
       (5, 'Grains/Cereals', 'Breads, crackers, pasta, and grains');


insert into products(id, product_name, supplier_id, category_id, price)
values (1, 'Chai', 1, 1, 18.00),
       (2, 'Chang', 1, 1, 19.00),
       (3, 'Aniseed Syrup', 1, 2, 10.00),
       (4, 'Chef Anton\'s Cajun Seasoning', 2, 2, 22.00),
       (5, 'Chef Anton\'s Gumbo Mix', 2, 2, 21.35);

# select 1
select *
from products
where product_name like 'C%';

#select 2
select *
from products
order by price
limit 1;

#select 3
select product_name, price
from products
         inner join suppliers on suppliers.id = products.supplier_id
where suppliers.country = 'USA';

#select 4
select distinct supplier_name
from suppliers
         inner join products on products.supplier_id = suppliers.id
         inner join categories on categories.id = products.category_id
where categories.category_name = 'Condiments';

#insert3
insert into suppliers(supplier_name, city, country)
values ('Norske Meierier', 'Lviv', 'Ukraine');

insert into products(product_name, supplier_id, category_id, price)
values ('Green tea', 6, 1, 10.00);