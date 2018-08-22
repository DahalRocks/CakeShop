# CakeStore

The task:

This is a core of a system for a cake store. The code written  is supposed to be used by other developers, who will create
other parts of the system (such as the user interface). The store makes three types of cakes: Kransekaker, Chocolate Cakes and Bløtkaker. 
They only make the cakes on order. They are looking for a system to keep track of their customers and which cakes are ordered and
delivered. For each customer, an ID, a name, a quantity of cakes ordered but not delivered, and a quantity of cakes ordered and delivered
must be registered.For each ordered cake, the system stores the customer, the type of cake and the time the cake was ordered.
For each delivered cake, the system stores the customer, type of cake, and both the time the cake was ordered and the time the cake
was delivered.

# Functionality Requirements 1: Registration

Create a method to register a new customer. Take the name as a parameter. Customer ID should be generated by the system.

Make a method to register that a cake is ordered. Take the customer ID, what type of cake, and the time of ordering as parameters.

Make a method to record that a cake is delivered: Take the customer ID, what type of cake, and the time of delivery as parameters.
If the customer has ordered more than one cake of this type (not yet delivered), this delivery applies to the non-delivered cake as 
long as it was ordered.

# Functionality Requirements 2: Extraction

Create a method that extracts a customer (with information about both name and ordered / delivered cakes) based on customer ID.

Create a method that extracts all the customers sorted alphabetically by name.

Make a method that extracts the longest time from a cake was ordered until it was delivered (regardless of who ordered it).


# Functionality Requirements 3: Error Management

When problems arise in the system, for example, if an attempt is made to register an order for a customer that does not exist,
or if an invalid input is entered for a method then this should be treated with care.
