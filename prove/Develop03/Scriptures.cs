
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
class Scriptures
{
private string _thescripture;
private List<string> _scriptureList;
public Scriptures(string chosen){
    _thescripture=chosen;
    _scriptureList = _thescripture.Split(' ').ToList();
}

Random random = new Random();

private int ScriptureLength(){return _scriptureList.Count;}


public List<string> HideWord()
    {int _randomIndex = 0;
        string _randomWord= "";
        for( int i=0; i < 3; i++ )
        {   
        
        if (!_scriptureList.Any(w => !w.Contains('_'))) { break; }
        bool alreadyHidden= true;
        while(alreadyHidden){
        _randomIndex= random.Next(ScriptureLength());
        _randomWord= _scriptureList[_randomIndex];
        if (!_randomWord.Contains('_')){alreadyHidden = false;}
        }
        Word word = new Word(_randomWord);
        word.HideWord1();
        _scriptureList[_randomIndex]=word.GetWordString();   
    }return _scriptureList;
    } 
}