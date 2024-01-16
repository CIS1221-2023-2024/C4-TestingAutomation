# Testing Automation

# Context – Software/Code Testing

Software testing is a crucial aspect of software development which ensures the reliability and stability of code. As a context, the primary types of code testing which can be automated primarily encompass the following types of tests: 

-	Functional testing, where the software is validated to ensure it functions as expected.
-	Unit testing, where individual components or functions of the software are tested independently.
-	Integration testing, where interactions between different components or modules are reviewed/verified.
-	Regression testing, where it is ensured that existing functionality is not negatively impacted by any new changes .
-	Performance testing, where the system’s stability and responsiveness under varying conditions, including varying loads and/or edge cases, is assessed.

Test Coverage is another pertinent aspect that is relevant to software development. Test coverage is a measure to determine the extent to which a particular test suite tests (covers) a given piece of code, i.e., indicating which areas of a program are exercised (covered) by the tests, and those that are not. The aim is to ascertain that testing efforts are comprehensive and in particular, critical parts of the code are adequately exercised. Key aspects of test coverage include statement coverage, branch coverage, path coverage, function and method coverage, condition coverage and loop coverage. 

Boundary and value analysis, which involves testing values at boundaries/edges of input domains, is another related aspect, which ensures that software behaves as expected at the extremes of input ranges.


# Definition & Overview – Testing Automation

In coding, the concept of testing automation involves the use of code scripts and automated tools to perform automated software testing tasks. 

The main aim of testing automation is to enhance the efficiency, effectiveness and the coverage of the code testing process.

There are a number of crucial concepts and considerations relating to testing automation that are key to the concept of testing automation itself.

One of the primary considerations is Automation Frameworks, which could be tools, standard operating procedures, (a set of) guidelines, and/or best practices to assist in automation of the testing process. These would provide a structured way to develop, organise and execute such automated tests, whilst facilitating ease of maintenance and scalability of automation efforts.

Another fundamental consideration is Test Automation Tools, i.e. software applications that assist in creating, executing, and analysing automated tests. Selection of such tools is based on programming language compatibility, ease of integration with other required tools, and the type of application under review (web, mobile, or desktop). Some examples of popular testing automation tools, which are dependent on the programming language being used, include JUnit (Java), NUnit (C#), and UnitTest (Python) (the latter two were utilised for this assignment)

Another key aspect worth considering is that of Continuous Integration/Continuous Deployment (CI/CD) systems. In this context, integration is attained thorough automated tests that are (often) integrated into CI/CD pipelines to ensure that any new code changes/modifications are automatically tested before final deployment. Meanwhile, quick feedback on the quality of the new code changes/modifications helps with early detection and resolution of any arising issues, in what is referred to as the feedback loop. An example of a CI/CD system is GitHub Actions, specifically, GitHub workflows, utilising YAML syntax, which enables automation of workflows (including building, testing and deployment processes) for GitHub platform repositories. (the latter was also utilised for this assignment) 

In terms of best practices for testing automation, the following points are relevant:

-	it should be noted that is better to start with a small, manageable set of test cases, before proceeding to larger or more complex test routines.
-	it is pertinent to note that not all coding tests are suitable for automation purposes and selection of appropriate tests is essential, hence, prioritisation should be based on criticality and frequency.
-	It is worth keeping in mind that regular maintenance is vital, hence, code scripts and test data should be kept up to date, to avoid any possible false positives/negatives.
-	It is suggested that in order to attain the best test coverage possible, collaboration between developers and testers should be encouraged and supported.

The primary benefits of testing automation are consistency, reusability and efficiency.

-	Consistency is evident as automated tests will perform the same test steps in the same way, every time, thereby eliminating any variability that would otherwise be introduced by human testers.
-	Reusability is manifested as automated test scripts can be reused across different versions/iterations of the code, thereby reducing the effort required for regression testing.
-	Efficiency is apparent as automated tests can be executed much faster than manual tests, and hence allow for quicker feedback on the quality of the code.

In the meantime, the key challenges faced in testing automation can be summarised as:

-	the Initial investment, since setting up and such automation requires considerable time and resources.
-	Unsuitability of tests, since some tests may be challenging or even impossible to automate, particularly those requiring human judgement or intervention.
-	Maintenance, as test scripts need to be continuously and rigorously updated as the software evolves.
-	Management of Test Data, as ensuring consistent and reliable test data is critical but can be challenging.

Nevertheless, irrespective of the programming language being used, the principles of testing automation, generally remain consistent across the different frameworks available. Moreover, whilst it is obvious that testing automation is a powerful tool, it should form part of an effective and comprehensive testing strategy, that also encompasses manual testing (as well as other types of testing required). This will ascertain through coverage of the software’s quality and ensures that potential issues are identified and addressed before final deployment.


# The Assignment/Project

# A Stack

For this assignment, after due consideration and discussion with the lecturer/mentor, the team decided to demonstrate the testing automation concept around a simple stack implementation.
Initially, a stack program was modelled, complete with all the typical functionality associated with it. The functions incorporated are: 

-	is_empty (checks whether the stack is empty)
-	peek (displays and returns the top element of the stack)
-	count_length (displays and returns the count/number of elements in the stack)
-	index (displays and returns the index of the specified element in the stack)
-	display (displays the current contents of the stack)
-	push (push the specified element onto the top of the stack)
-	pop (pop and display the top element of the stack)

An element of input validation is also built into the stack function, to ensure that the stack program functions optimally (only digits are allowed as input, and cancellation of actions/operations is also allowed in some cases).

The stack functionality is supplemented by a front-end menu interface, which allows for user input and interaction, as well as the requisite main program logic, which coordinates stack operations/functions based on user input.

# Test Suites

Subsequently, the testing automation concept was shown by building a complete suite of tests for the stack functions/methods. The aim of the test suite was to provide coverage of the core functionality of each of the stack’s functions/methods.

This ensures adequate test coverage in terms of functional testing and unit testing (since tests were modelled for each of the stack’s functions/methods). However, as the aim was to cover the core functions of each of the seven stack functions (providing a horizontal approach), the tests do not exhaust all the possible (edge/volume/load etc.) functionality of the stack methods (a deep/vertical approach), since the team did not have the necessary time and resources to model these tests in a proper manner for this assignment.

Moreover, the tests were designed so that they can either be run independently by the developer/tester, or automatically (after being provided with the appropriate instructions) taking advantage of available automation tools.

# Programming Languages and Testing Frameworks

In terms of programming languages used for this assignment - the above-mentioned stack implementation and testing suite, it was decided to use C# and Python programming languages. In spite of their inherit difference, for both languages, Python included, the code was constructed in an object-oriented manner, as far as possible, to provide a logical, organised and easy to understand code, whilst being modular and allowing for easy modification and/or enhancements. This would also allow for a fair comparison of performance and volume test runs if the need arises. 

In this regard, in terms of testing frameworks, Python testing was built around the UnitTest framework, whilst C# testing was built around the NUnit framework. Both testing frameworks provide specialised functions which allow for various tests to be built and run.

In terms of workflow, the team was instructed to upload their work on and utilise the GitHub platform repository. Apart from the main branch, separate branches were created for each team member accordingly.

# Test Functions

In terms of the tests, looking at the Python implementation as an example (C# aims to take a similar if not completely identical approach), a number of tests were built, grouped as functions/methods. Each function/method groups tests for each of the stack’s functions/methods. As a result, testing class contains eight testing functions/methods, with self-explanatory names, as follows:

-	test_is_empty
-	test_peek
-	test_count_length
-	test_index
-	test_display_base_initial
-	test_display_capture
-	test_push
-	test_pop

Each test function contains: 

-	comments for each specific test, describing/indicating what the test will be testing, to aid code/test reviews.
-	the respective tests for that stack function.
-	a text message for each specific test, indicating the expected output, and displayed during the test execution.
-	text messages indicating initiation and completion of the function’s tests, which are displayed at the start and end of the function’s tests respectively.

# Testing Notes

Continuing with the Python implementation as an example, after initiating a stack instance, each test function typically tries to assert the state of the stack (empty) at the start, as well as assert the state/result of the stack after a push and pop operations, or series thereof, typically using simple known initial values such as ‘1’ and ‘2’ etc. In this manner, extreme/edge cases where the stack is empty, or has just one value added (pushed), or the only value removed (popped), are tested.

The test_count_length function also includes a (commented out) example of a failed test, which expects the length of an empty stack to be 0, when in fact, an if else condition in the count_length function in the stack ensures a ‘none’ return with an error message being printed. The test is commented out as it is not relevant in our stack implementation. 

Two test_display functions are provided. The first function provides basic tests, ensuring that the stack display function works and the program does not halt. The second function utilises the sys and StringIO modules/classes to capture output, and uses this output to match/compare with the expected test result, thereby ensuring optimal operation of the display function.

The test_push function also provides a test for pushing a different data type (string), should the need arises. Whilst the test passes, and the push function within the stack works correctly with this data type, this functionality is not required in our stack implementation, as input validation ensures that only valid (digits) input are accepted.

# Running the Tests & Observations

Upon loading the Python project file (with the main.py and test_main.py files) in a compatible IDE, along with running/executing the (main) stack program, the user is encouraged to run/execute the test suite (test_main) to experience/check out the tests. In this case, upon running/executing, all the tests in the test class will execute automatically, with no user input being required. During execution, the IDE should display a number of test messages indicating test progress. Moreover, upon test completion (execution) the test result (passed/failed) and the execution time will also be displayed (Provided that the tests are run on a compatible/featured IDE. Developer testing was conducted using PyCharm with Python 3.1X base/kernel).

As at the assignment deadline, the final test suited executed flawlessly, providing a clean test passed result, and an execution time measured in milliseconds (typically hovering around 40/30/20 milliseconds (initial test runs obviously take the longest to execute) (test runs never came close to or exceeded 100 milliseconds) on a 10th Gen Core i5 G machine with 8gb of RAM), calculated over numerous test runs on the same (developer) machine. Similar tests were conducted for the C# test suite.

# Enabling Testing Automation

After the respective test suites were created/completed in C# and Python, the final stage of the assignment/project consisted of uploading our code on our respective GitHub branch within the GitHub Project, as well as understanding and making use of GitHub Action’s built in workflows. This fully demonstrates Testing Automation in our assignment on a CI/CD system/environment which was attained by integrating and automating our test suites into the GitHub workflow pipeline, thus ensuring that any code changes/modifications are automatically tested upon final deployment.

In this regard, utilising the YAML syntax, a workflow was set up, whereby upon detecting any push onto the main branch, the appropriate .Net and Python environments are set up, and the respective NUnit and UnitTest tests are automatically run and executed on the respective C# and Python Stack implementation, thereby verifying whether the updated (stack) code being pushed onto the main branch would pass of fail the respective test suite.

In terms of the test results, users can see and access the tests in progress, as well as the final test result (a red X or a green ‘check’ mark) on the top of the project files, when viewing in the main branch. 

Moreover, users may access and see individual test results (pass or fail) upon each push to the main branch, by accessing the GitHub Actions menu tab, where each workflow run and result are accessible, along with relevant information message and time stamp.

Finally, it is worth noting that if testing automation workflow fails (upon pushing to the main branch), the GitHub team contributors will each be notified of the failed test by receiving an email in their registered inbox, notifying theme that the respective test (upon push to main branch) has failed, with the appropriate error message/s and info.

