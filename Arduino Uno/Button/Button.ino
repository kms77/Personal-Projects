#include <LiquidCrystal.h>
LiquidCrystal lcd(7, 8, 9, 10, 11, 12);
void setup() { 
  lcd.begin(16, 2);
  int x='a',g=0,i=0,j=0;
  while(g==0)
        {
         if(x>'z')
            {
             g=1;
             lcd.clear();
             delay(500);
             lcd.print("Have a nice day!");
             delay(2500);
             lcd.clear();
            }
          else
             {
              if(j==16)
                 {
                  j=0;
                  if(i==1)
                     {
                       i--;
                       lcd.setCursor(j,i);
                       lcd.clear();
                     }
                  else
                     {
                      i++;
                      lcd.setCursor(j,i);
                     }
                 }
              lcd.setCursor(j,i);
              lcd.print(char(x));
              lcd.setCursor(j+1,i);
              lcd.print("");
              x++;
              j+=2;
              delay(200);
             }
        }
}
void loop() {
}
