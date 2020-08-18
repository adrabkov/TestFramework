Feature: Log Out from the application
    In order to avoid bugs connected with Log Out from the application
    As a client,
    I want to click log out button and successfully log out from the application 

    Scenario: Log Out from the application
        Given I have login into application using test credentials
        Then I verify that the user has successfully log in to the app
        When I click top profile menu
        And I click log out button
        Then I verify that login page is open