# 1. Reflections

## 1.1 COMPUTER MOUSE 
Identify the types of testing you would perform on a computer mouse, to make sure that it is of the highest quality.
- Check if the mouse is optical or nor. Usually optical mouses won’t need cleaning (or much of it) as there are no moving parts in it. Older models used to have a ball, where dust and other stuff would be a problem if accumulated.
- Check both right and left click buttons are working correctly. Does the computer register the clicks?
- Check that the double-click function is working correctly. Also test for time between clicks to test what is considered a double-click.
- Test the scroller on the mouse. Does it correctly scroll in the specified direction that the settings are saying?
- If there are side buttons, check their functionality, are they working properly?
-Verify that movement is translated correctly to the cursor on the computer i.e. moving mouse forward moves the cursor upwards and so on.
- Check the build quality of the mouse. Weight, materials used, is anything rustling inside the mouse when shaken.
- Check the form factor, is it right-handed, left-handed, or ambidextrous? Is the size appropriate? Does its form give the use a good grip?
- If the mouse is wireless, test the battery life.


## 1.2 CATASTROPHIC FAILURE 
Find a story where a software system defect had a bad outcome. Describe what happened. Can you identify a test that would have prevented it?

### The story:
The Mars climate orbiter was launched by NASA on december 11, 1998 and was supposed to study the martian climate, martian atmosphere and surface changes. However NASA permanently lost contact to the spacecraft on september 23, 1999 as it was about to enter orbit insertion. The spacecraft encountered Mars on a trajectory that got it too close to the planet, and it was either destroyed in the atmosphere or escaped the planet’s vicinity and entered an orbit around the sun. An investigation attributed the failure to a measurement mismatch between two software systems: metric units by NASA and imperial units by spacecraft builder Lockheed Martin. 

Source on story: [NASA](https://solarsystem.nasa.gov/missions/mars-climate-orbiter/in-depth/) and [Mars Climate Orbiter Wiki](https://en.wikipedia.org/wiki/Mars_Climate_Orbiter) 

The most obvious test that could have been implemented would be to test that the measurements by NASA and Lockheed Martin actually matched. By running a series of tests making sure that different variations of metric were converted correctly to imperial and the other way around. This test would ensure that the calculations of both teams are correctly translated, since you can’t expect a government organisation and one of the largest aerospace manufacturers to communicate together.  

This is very oversimplified, since the calculations made by NASA and Lockheed Martin are very complex. The tests could/would have helped, but with aerospace engineering requiring very detailed and precise calculations, the teams should have agreed on a standard beforehand. 


# 3. Investigation of tools
**@Tag**: Tests can be tagged with a custom tag. You can put a tag on all integration tests and a tag on unit tests. You can choose to execute all tags under a given tag name, so you could choose to only run all unit tests, by this you are essentially filtering using tags.

**@Disabled**: You can disable specific tests if you choose. This is useful for tests where functionality hasn't been implemented yet.

**@RepeatedTest**: The test execution is repeated for a certain number of times.

**@BeforeEach, @AfterEach**: BeforeEach is used on a method containing some code that must be run before each test. AfterEach is similar but instead of running code before the tests, it’s run afterwards. BeforeEach could contain some code to reinitialize a class needed for the test, and AfterEach could contain some code to roll back database modifications.

**@BeforeAll, @AfterAll**: An annotation for a method containing code needed to be run before or after the whole test fixture (the whole test class). Its application could be useful for initialization code before all tests are executed or cleanup code after.

**@DisplayName**: An annotation used to display custom text on a test class or method. Can be useful to make it to read which tests are executed

**@Nested**: This annotation allows the user to create inner test classes. It makes it easier to group tests in a large test suite, which helps with organizing the tests.

assumeFalse, assumeTrue: These are both methods of the assumption class, which are used to validate a given assumption. When an assumption fails it will result in a test being aborted, instead of failure as seen with assertions.

## 3.2 Mocking frameworks

For c# it seems that the two most popular mocking frameworks are MOQ and NSubstitute. 

### Similarities and differences

In form of limitations and capabilities, it would overall seem that both frameworks are capable of the same tasks, although there is some variation of how well each does, and some of the points comes down to personal prefrence. To see some of the differences lets look at readability, and flexability of matching arguments. 

### **Mock Creation**

**MOQ**

```
var mock = new Mock<IRepository>();
``` 

**NSubstitute**

````
var mock = Substitute.For<IRepository>(); 
````

MOQ is easier to read, but NS is not a lot harder to understand.

### **Mocking properties** 

**MOQ**
````
mock.Setup(foo => foo.Users).Returns(userList);
````
**NSubstitute**
````
mock.Users.Returns(userList);
````

NSubstitute is a lot easier to read and understand, with more simplicity. 


### **Matching Arguments**

**MOQ**
````
It.IsAny<int>())
It.IsInRange(0, 10, Range.Inclusive) 
It.IsIn(Enumerable.Range(1, 5))
It.IsNotIn(Enumerable.Range(1, 5))
It.IsNotNull<string>())
It.IsRegex("abc"))
It.Is<int>(i => i < 10))
````
**NSubstitute**
````
Arg.Any<int>())
Arg.Is<int>(i => i < 10))
````

A lot more built in options are provided my MOQ, providing more flexability in validation.

### **My preference**

Generally i prefer the readability of NSubstitute. Although it does seem that MOQ is a bit more customisable. I think i will need to have to work a bit more in depth with both frameworks before i can give a definitive answer. From the forum posts, blog posts and articles I've read it does not seem like NSubstitute has any limitations compared to MOQ, even though it seems like MOQ can do more detailed results. I will most likely go with NSubstitute until i reach a wall that was not described in anything I've read so far. 

### 3.1 sources
[NSubstitute webpage](https://nsubstitute.github.io/)

[MOQ Wiki](https://github.com/Moq/moq4/wiki/Quickstart)

[Comparing .NET Mocking Libraries](https://www.danclarke.com/comparing-dotnet-mocking-libraries)

[Moq vs NSubstitute - Who is the winner?](https://dev.to/cloudx/moq-vs-nsubstitute-who-is-the-winner-40gi)