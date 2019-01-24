﻿Feature: DFC-6183 View Course - Description
As a Provider
I need to view the Course Description
so that I can review the course description content that was added when the course was created

Background:
	#Given I have logged into course directory as a provider
	#And I have navigated to the Your-Courses Page
	#And accordion of courses is maximised

	## Given I have accessed my courses
	Given I have accessed the Course Directory as a provider
	## Use Provider Search to Navigate o course for a Provider
	And I have navigated to the Search Provider Page
	When I enter 10028015 and click search provider
	And I click to view my courses
	## End of Provider Search Steps
	Then I want to view the course details
	#And I open the course details accordian for diploma
	#And I click on the view course description link

@CI
Scenario: View description of the first course 
	Given I have clicked the Main Qualification
	Given I click on the view course description link
	Then course description pop-up opens
	And qualification title is shown
	And Who is the course for is shown
	And Entry requirements are shown
	And What you’ll learn is shown
	And What you'll need to bring is shown
	And How you'll be assessed is shown
	And Where next? is shown
	When I click close view course description pop-up button 
	Then course description pop-up is no longer visible


