Feature: AddNewProduct

Add New Product


Scenario: Add New Product
	Given I logging in
	When I tap AllProduct and CreateProduct
	Then I check