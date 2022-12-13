using Testing;
using Logging;

var tester = new Tester();
var betaTester = new BetaTester();
var logger = new Logger();

tester.TestComplete += logger.Log;
betaTester.TestComplete += logger.Log;

tester.PerformTest();
betaTester.PerformTest();
