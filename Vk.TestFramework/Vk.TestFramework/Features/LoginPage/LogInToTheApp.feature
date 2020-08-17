Feature: Log in to the application
    In order to avoid bugs connected with log in to the application
    As a client,
    I want to enter login and password and successfully log into the application 

    Scenario: Log in to the application
        Given I have login into application using test credentials
        Then I verify that the user has successfully log in to the app