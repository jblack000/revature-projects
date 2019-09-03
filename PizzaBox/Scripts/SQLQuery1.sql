select * from Toppings;

insert into Toppings(name, price) values('cheese',1.99);
insert into Toppings(name, price) values('sauce',2.99);
insert into Toppings(name, price) values('ham',3.99);
insert into Toppings(name, price) values('bacon',4.99);
insert into Toppings(name, price) values('beef',5.99);
insert into Toppings(name, price) values('sausage',6.99);
insert into Toppings(name, price) values('pepperoni',7.99);

select * from Sizes;

insert into Sizes(name, price) values('small',1.99);
insert into Sizes(name, price) values('medium',2.99);
insert into Sizes(name, price) values('large',3.99);
insert into Sizes(name, price) values('xlarge',4.99);

select * from Crusts;

insert into Crusts(name, price) values('thin',1.99);
insert into Crusts(name, price) values('traditional',2.99);
insert into Crusts(name, price) values('handtossed',3.99);
insert into Crusts(name, price) values('stuffed',4.99);


select * from Pizzas;

delete from Pizzas;