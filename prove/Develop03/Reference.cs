using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

class Reference
{

    private int _scriptureChoice;
    public Reference(int input){_scriptureChoice = input ;}


    
    private string _scr1 ="And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
    private string _scr2 = "For behold, this is my work and my glory —to bring to pass the immortality and eternal life of man.";
    private string _scr3 = "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled.";
    private string _scr4 = "Come unto me, all ye that labour and are heavy laden, and I will give you rest." ;
    
    private string ChosenScripture;

    public string GetScripture(){return ChosenScripture;}
    public void ChooseScripture(){
    if(_scriptureChoice == 1){Console.WriteLine("1 Nephi 3:7");Console.WriteLine(_scr1); ChosenScripture= _scr1;}
    else if(_scriptureChoice == 2){Console.WriteLine("Moses 1:39");Console.WriteLine(_scr2); ChosenScripture= _scr2;}
    else if(_scriptureChoice == 3){Console.WriteLine("D&C 1:37-38");Console.WriteLine(_scr3); ChosenScripture= _scr3;}
    else if(_scriptureChoice == 4){Console.WriteLine("Matthew 11:28");Console.WriteLine(_scr4); ChosenScripture= _scr4;}  
    else {Console.WriteLine("error");}  
    }

    public string GetChosen(){return ChosenScripture;}





}




