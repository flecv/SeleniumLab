Feature: to run tests

  Scenario: Check contacs us button
    Given User has opened the main page
    When User clicks on contact us button
    Then User see contact us page

  Scenario: Check language button
    Given User has opened the main page
    When User hovers the cursor on language button
    And User click on Ukrainian button
    Then User see that page changed language

  Scenario: Check INFOGEN button
    Given User has opened the main page
    Then User goes down the page
    When User click INFOGEN button
    Then User is redirected on infogen page

  Scenario: Check We are in button
    Given User has opened the main page
    Then User goes down the page 
    When User click on facebook button
    Then User is redirected on the site facebook page 

  Scenario: Check Our results button
    Given User has opened the main page
    Then User thumbs through the page 
    When User clicks on Learn more button 
    Then User is redirected on our work page

  Scenario: Check Find your dream job button
    Given User has opened the main page
    Then User thumbs through the page  
    When User clicks on Find your dream job button
    Then User is redirected on page

  Scenario: Check button hover
    Given User has opened the main page
    When User point cursor to DESIGN
    Then User check that it is hovered by text

  Scenario: Check search button
    Given User has opened main page
    Then User click on loupe button
    And User enter 'Cloud'
    Then User check that page changed to search result