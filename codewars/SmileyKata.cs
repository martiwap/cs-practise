using System;

public static class SmileyKata
{
  public static int CountSmileys(string[] smileys) 
  {
    if (smileys.Length == 0) return 0;
    
    int totalFaces = 0;
    
    foreach (string face in smileys)
     {
       string firstChar = face.Substring(0, 1);
       string lastChar = face.Substring(face.Length -1);
  
       if (face.Contains(" "))
        {
           continue;
        }
         
       if (IsItAFace(firstChar, lastChar))
       {
         totalFaces++;
       }
     }
     
    return totalFaces;
  }
  
  
  public static bool IsItAFace(string eyes, string mouth)
  {
    if ((eyes.Equals(":") || eyes.Equals(";")) && (mouth.Equals(")") || mouth.Equals("D"))) 
    {
      return true;
    }
    
    return false;
  }
}
