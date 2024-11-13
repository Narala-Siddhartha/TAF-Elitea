Feature: Login Functionality

  Scenario: Successful Login with Valid Credentials
    Given I am on the login page
    When I enter valid username 'standard_user' and password 'secret_sauce'
    And I click on the login button
    Then I should be redirected to the products page at 'https://www.saucedemo.com/inventory.html'

  Scenario: Failed Login with Invalid Username and Password
    Given I am on the login page
    When I enter invalid username 'invalid_user' and password 'wrong_password'
    And I click on the login button
    Then I should see an error message

  Scenario: Failed Login with Invalid Username
    Given I am on the login page
    When I enter invalid username 'invalid_user' and valid password 'secret_sauce'
    And I click on the login button
    Then I should see an error message

  Scenario: Failed Login with Invalid Password
    Given I am on the login page
    When I enter valid username 'standard_user' and invalid password 'wrong_password'
    And I click on the login button
    Then I should see an error message