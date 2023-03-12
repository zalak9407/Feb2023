Feature: TM_Feature

As a turnup portal admin
I would like to create, edit time and material records
So that i can manage employees time and materials successfully

@tag1
Scenario: Create time and material record with valid details
	Given I logged into turnup portal successfully
	When I navigate to Time and Material page 
	And I create new Time and Material record
	Then The record should be created successfully
