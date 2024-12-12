using Antlr4.Runtime;
using OwnLanguage;
using OwnLanguage.Content;

var filename = Directory.GetCurrentDirectory() + "../../../../testOwnLanguageFile.txt"; // this would be the Path to our test file to compile

var fileCOntent = File.ReadAllText(filename);

// Boiler plate stuffs for Antlr
var inputStream = new AntlrInputStream(fileCOntent);
var grammerLexer = new GrammerLexer(inputStream);
var commonTokenStream = new CommonTokenStream(grammerLexer);
var grammerParser = new GrammerParser(commonTokenStream);
// grammerParser.AddErrorListener(new ErrorListener()); // need to implement error listener
var grammerContext = grammerParser.program();
var visitor = new SimpleVisitor();
visitor.Visit(grammerContext);












