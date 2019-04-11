Feature: Publish videos
  In order to notice the users
  As a teacher
  I want to send a notitification to subscribed users

  Scenario: Publish a new video
    Given I have created a Aggregate Root concept video about: How to create an aggregate root in a domain
    When I publish the video
    Then the system send a notification video was pulblished