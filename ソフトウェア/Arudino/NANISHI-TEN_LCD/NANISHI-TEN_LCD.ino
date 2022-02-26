//NANISHI-TEN Serial
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,16,2);

//****変数定義
int button = 7;
String val1;
String val2;
//***********

//****設定内容
void setup()
{
  //****シリアル通信
  Serial.begin(9600);

  //****LCDディスプレイ
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0,0); // 1行目の行頭にカーソルを移動します。
  lcd.print("NANISHI-TEN");
  lcd.setCursor(0,1); // 2行目の行頭にカーソルを移動します。
  lcd.print("Start !!");
  
  //****ボタン
  pinMode(button, INPUT);
}
//***********

//****繰り返し文
void loop()
{    
    if(Serial.available() > 0){
       switch(Serial.read()){
           case 'a':
               val1 = Serial.readString();
               val2 = "\xb4\xb8\xbe\xd9\xbb\xb7\xde\xae\xb3\xc1\xad\xb3\xc3\xde\xbd";  //エｸｾﾙｻｷﾞｮｳﾁｭｳﾃﾞｽ
               break;

            case 'b':
               val1 = Serial.readString();
               val2 = "\xbb\xb7\xde\xae\xb3\xc1\xad\xb3"; //ｻｷﾞｮｳﾁｭｳ
               break;

            case 'c':
               val1 = Serial.readString();
               val2 = "\xb7\xad\xb3\xb9\xb2\xc1\xad\xb3"; //ｷｭｳｹｲﾁｭｳ
               break;
            case 'd':
               val1 = Serial.readString();
               val2 = "\xbb\xb7\xde\xae\xb3\xa6\xbc\xad\xb3\xd8\xae\xb3\xbc\xcf\xbd"; //ｻｷﾞｮｳ終了します
               break;

            case 'e':
               val1 = Serial.readString();
               val2 = "\xc2\xb7\xde\xc9\xbc\xbc\xde\xa6\xcf\xaf\xc3\xb5\xd8\xcf\xbd"; //ﾂｷﾞﾉｼｼﾞｦﾏｯﾃｵﾘﾏｽ
               break;
               
            case 'f':
               val1 = Serial.readString();
               val2 = "\xc0\xbd\xb9\xc3\xb8\xc0\xde\xbb\xb2"; //助けてください
               break;
               
            default:
               break;
       }

       lcd.setCursor(0,0); // 1行目の行頭にカーソルを移動。
       lcd.clear();
       lcd.print(val1);  //作業者名
       lcd.setCursor(0,1); // 1行目の行頭にカーソルを移動します。
       lcd.print(val2);  //作業内容
      }


    int  var = digitalRead(button);
    if(var == HIGH){
      Serial.println("GOOD");
      delay(200);
    }
}
//***********
