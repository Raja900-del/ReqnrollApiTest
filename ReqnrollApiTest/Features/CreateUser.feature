Feature: CreateUser
Validate POST /api/users endpoint

  @APi
  Scenario: Successfully create a user
    When I create a user with name "Raja" and job "QA Engineer"
    Then the response status should be 201
