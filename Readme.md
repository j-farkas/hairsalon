# _Hair Salon_

#### _Allows a hair salon to create a list of employees and attach clients to one employee in the list_

#### By _**Jared Farkas**_

## Description

_Assigns clients to an employee within the list of employees. Should a client have too much hair cut, they will be killed and that employee may find scissors with which to more efficiently kill future clients. After each hair cut employees will also pocket any hair they cut, which can be utilized by them to increase their hair cutting efficiency_

## Setup/Installation Requirements

* _Clone from https://github.com/j-farkas/hairsalon.git_

*_To create the database:_*
>CREATE DATABASE to_do;
> USE to_do;
> CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255), stylist int(11), hair int(11));

  > CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255), description VARCHAR(255), level int(11), hair int(11), scissors int(11), scissors_name VARCHAR(255));

  >CREATE TABLE mods (id serial PRIMARY KEY, name VARCHAR(255));

  >INSERT INTO mods (name) VALUES ('Steel');
  >INSERT INTO mods (name) VALUES ('Silver');
  >INSERT INTO mods (name) VALUES ('Gold');
  >INSERT INTO mods (name) VALUES ('Diamond');
  >INSERT INTO mods (name) VALUES ('Magic');

  >CREATE TABLE suffix (id serial PRIMARY KEY, name VARCHAR(255));

  >INSERT INTO suffix (name) VALUES ('Chance');
  >INSERT INTO suffix (name) VALUES ('Luck');
  >INSERT INTO suffix (name) VALUES ('Fortune');
  >INSERT INTO suffix (name) VALUES ('Strength');
  >INSERT INTO suffix (name) VALUES ('Fragility');

* _Use dotnet run and load it from localhost_

## Specs

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| A stylist is added to the form | "Namey"  | A stylist is added to the database |
| A client is added to the form using a dropdown to select their stylist | "Clienty" | A client is added to the database with a foreign key to reference their stylist |
| In the client show screen, a new stylist is selected | n/a | the foreign key for the selected client is changed in the database to reflect their new stylist |
| In the client show screen, a haircut is selected and the client has hair remaining | n/a | The stylist keeps the hair and progresses towards the next level|
| In the client show screen, a haircut is selected and the client has negative hair remaining | n/a | The client is killed, a random pair of scissors is generated for the stylist, and hair is taken to progress the stylist to the next level|

## Known Bugs

_None currently known_

## Support and contact details

_Contact jaredmfarkas@gmail.com for support._

## Technologies Used

_C#, .Net, Razor asp.net, MySql_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2019 **_Jared Farkas_**
