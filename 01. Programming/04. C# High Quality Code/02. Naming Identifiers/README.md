#Naming Identifiers

**Exercises:**

1. Refactor the following examples to produce code with well-named C# identifiers:
  ```cs
  class class_123{
    const int max_count=6;
    class InClass_class_123  {
      void Метод_нА_class_InClass_class_123(bool promenliva)    {
        string promenlivaKatoString=promenliva.ToString();
        Console.WriteLine(promenlivaKatoString);    }
    }    
    public static void Метод_За_Вход()  {
      class_123.InClass_class_123 инстанция =
        new class_123.InClass_class_123();
      инстанция.Метод_нА_class_InClass_class_123(true); 
    }
  }
  ```

2. Refactor the following examples to produce code with well-named identifiers in C#:
  ```cs
  class Hauptklasse
  {
    enum Пол { ултра_Батка, Яка_Мацка };
  
    class чуек
    {
      public Пол пол { get; set; }
      public string име_на_Чуека { get; set; }
      public int Възраст { get; set; }
    }
  public void Make_Чуек(int магическия_НомерНаЕДИНЧОВЕК)
    {
      чуек new_Чуек = new чуек();
      new_Чуек.Възраст = магическия_НомерНаЕДИНЧОВЕК;
      if (магическия_НомерНаЕДИНЧОВЕК%2 == 0)
      {
        new_Чуек.име_на_Чуека = "Батката";
        new_Чуек.пол = Пол.ултра_Батка;
      }
      else
      {
        new_Чуек.име_на_Чуека = "Мацето";
        new_Чуек.пол = Пол.Яка_Мацка;
      }
    }
  }
  ```
  
3. Refactor the following examples to produce code with well-named identifiers in JavaScript:
  ```javascript
  function _ClickON_TheButton( THE_event, argumenti) {
    var moqProzorec= window;
    var brauzyra = moqProzorec.navigator.appCodeName;
    var ism=brauzyra=="Mozilla";
    if(ism)  {
      alert("Yes");  }
    else
    {
      alert("No");  }
  }
  ```

4. Refactor and improve the naming in the C# source project "[3. Naming-Identifiers-Homework.zip](https://github.com/BorislavIvanov/Telerik_Academy/tree/master/01.%20Programming/04.%20C%23%20High%20Quality%20Code/02.%20Naming%20Identifiers/Task%204%20files)". You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.
