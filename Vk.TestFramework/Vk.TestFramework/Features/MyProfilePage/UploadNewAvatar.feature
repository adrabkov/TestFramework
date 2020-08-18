Feature: Upload a new avatar
    In order to avoid bugs connected with upload a new avatar
    As a client,
    I want to upload a new avatar for my profile 

    Scenario: Upload a new avatar
        Given I have login into application using test credentials
        Then I verify that the user has successfully log in to the app
        When I click My profile menu
        When I click upload a profile photo
        And I upload a new photo
        Then I verify that owner photo is display
        When I click Save and continue button
        And I click Save button
        Then I verify that avatar is display
