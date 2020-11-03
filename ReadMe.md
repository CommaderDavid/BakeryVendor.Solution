# Bakery Vendor
#### 3.2.5.1, for Fidgetech
#### Date:8/6/2020  by:_**David Boedigheimer**_
### Description
This program allows the user to add and view Vendors to Pierre's Bakery. Then add Orders to those vendors to show product and orders placed by each vendor. This project uses C# as its main language, along with CSS and Bootstrap for orginazation.
### BDD Process
1. User enters what order they want to add.
      * **Input**: Donuts
      * **Output**: Order added to a new order list.
2. User enters what Vendor they want to add.
      * **Input**: Dave's Donuts
      * **Output**: Vendor added to a new vendor list.
3. User can view vendor in a list.
      * **Input**: View Vendors
      * **Output**: 1. Dave's Donuts 2. Mikes pies
4. User can view orders under a vendor in a list.
      * **Input**: View Orders under first vendor
      * **Output**: 1. Donuts 2. Cream filled donuts
5. User can view extra details in the Orders.
      * **Input**: View first order
      * **Output**: 12 dozen orders of Donuts, $380, ordered on the 15 of october 
### Setup
* Type in `$git clone https://github.com/CommaderDavid/BakeryVendor.Solution.git`
* Navigate to the BakeryVendorTests folder
* Run `dotnet restore` in the terminal
* Navigate to the BakeryVendor folder
* Run `dotnet build` then `dotnet run', and enjoy.
### Contact
Contact me if you have any concerns or questions at stealth259@gmail.com
### Known bugs
There are no known bugs in this program.
### License
This program is lisensed under the MIT license.
Copyright (c) 2020 _**David Boedigheimer**_
