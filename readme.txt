This is a readme file
Added solution to the repo
Test aliases
Finished with basic test framework, now it's ready for refactoring
=====
TestFrm v2.0
- Added RemoteWebBrowser instead of local browser
- Created parent tests class
- Added class and test setup/teardown attributes
- Created parent pages class
- Moved urls and settings to config
- Moved browser creation to class
- Changed mstest to nunit

TestFrm v2.1
- Added screenshots on test fail
- Added logger on common actions like test start

TestFrm v2.1.1
- Added base try-catch for tests, changes below are implemented inside catch
- Added logger on test fail
- Screenshots called from catch, not from teardown as before