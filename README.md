# string-processor

Tech Test
=========

# Overview 

The test consists of two projects:

- StringProcessor - the main project.
- StringProcessor.Tests - the unit test project (using xUnit).

# Tasks

1. Write code in the main project to ensure that the four unit tests pass.  
   **Note: for the purposes of this test, a word includes punctuation. "I'm" is a single word and "that." is five characters long (including the full-stop).**
  

2. Add a project and code to the solution to fulfil the following requirement:
   > GIVEN a text string  
   > WHEN it is sent to a HTTP API endpoint  
   > THEN JSON representing the populated StringStatsModel is returned  
   
   Ensure that you can test this via your preferred method (Postman, integration test or webpage, etc)  
  

3. (Optional / for bonus points) Write a fifth unit test which tests very large input to the StringStatsProcessor.Run(string) method.
