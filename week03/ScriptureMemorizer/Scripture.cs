using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>(); 
    private int _hiddenWords;
    private bool _isComplete;
    


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
        _hiddenWords = 0;
        
    }

    public void HideRandomWords()
    {
        //hide random words
        int numberToHide = -1;
        bool letters = true;
        //loop through words to hide until one is found that is not hidden
        while (letters)
        {
            //If the word is hidden loop we continue to find a word that is not hidden
            Random random = new Random();
            numberToHide = random.Next(0, _words.Count);
            Word word = _words[numberToHide];
            //word GetDisplayTaxt shows the word, if it shows "_" as the first character the word is hidden
            //If hidden letter is changed to false and stops the loop
            if(word.GetDisplayText().StartsWith("_"))
            {
                letters = true;
            } else {
                letters = false;
            }
            
        }
        
        
        if (_words[numberToHide].IsHidden() == false)
        {
            _words[numberToHide].Hide();
            //count number of hidden words
            _hiddenWords++;
        }
        

    }

    public string GetDisplayText()
    {   
        //return the reference and words
        //after words are hidden, return the hidden words as underscores
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(word =>word.GetDisplayText()))}";
        
    }

    public void Complete()
    {
        //when all words are hidden return false
        if (_hiddenWords == _words.Count)
        {
            _isComplete = true;
        } else {
            _isComplete = false;
        }
    }

    public bool IsCompletelyHidden()
    {
        Complete();
        return _isComplete;
    }

}