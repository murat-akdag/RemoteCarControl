int motor1_ileri=2;   
int motor1_geri=3;    
int motor2_ileri=4;    
int motor2_geri=5;    
int motor3_ileri=9;
int motor3_geri=8;
int motor4_ileri=7;
int motor4_geri=6;
///////////////////
int robot_sag=10;
int robot_sol=11;
int robot_duz=12;
/////////////////////////
int hiz=80;
int hizy=160;

int rotate=51;
int rotate1=60;
int SerialData=0;
void setup() 
{ 
  pinMode(motor1_ileri, OUTPUT);
  pinMode(motor1_geri,OUTPUT);
  pinMode(motor2_ileri,OUTPUT);
  pinMode(motor2_geri,OUTPUT);          
  pinMode(motor3_ileri,OUTPUT);
  pinMode(motor3_geri,OUTPUT);
  pinMode(motor4_ileri,OUTPUT);
  pinMode(motor4_geri,OUTPUT);
  pinMode(robot_sag,INPUT);
  pinMode(robot_sol,INPUT);
  pinMode(robot_duz,INPUT);
} 
void loop() 
{
 
 int butonDurum_sag=digitalRead(robot_sag);
 int butonDurum_sol=digitalRead(robot_sol);
 int butonDurum_duz=digitalRead(robot_duz);
   
    if (( butonDurum_sag==0)&&( butonDurum_sol==0)&&( butonDurum_duz==1))                                               
    {  
      dur();
      analogWrite(motor2_geri,hiz);
      analogWrite(motor4_geri,hiz);
    }
     else if(( butonDurum_sag==0)&&( butonDurum_sol==1)&&( butonDurum_duz==0))                 
    {
      sifirlama();
      analogWrite(motor1_ileri,rotate1);
      analogWrite(motor2_geri,rotate);
      analogWrite(motor3_geri,rotate1);
      analogWrite(motor4_ileri,rotate); 
    }
    else if(( butonDurum_sag==1)&&( butonDurum_sol==0)&&( butonDurum_duz==0))                  
    {
      dur();
      analogWrite(motor1_geri,rotate1);
      analogWrite(motor2_ileri,rotate);
      analogWrite(motor3_ileri,rotate1);
      analogWrite(motor4_geri,rotate); 
    }
    
    else if(( butonDurum_sag==0)&&( butonDurum_sol==0)&&( butonDurum_duz==0))                  
    {
      dur();

    }

   else if (( butonDurum_sag==0)&&( butonDurum_sol==1)&&( butonDurum_duz==1))                                               
    {  
      dur();
      analogWrite(motor2_ileri,hiz);
      analogWrite(motor4_ileri,hiz);
    }  
}


void dur()
{
  analogWrite(motor1_ileri,0);
  analogWrite(motor2_ileri,0);
  analogWrite(motor3_ileri,0);
  analogWrite(motor4_ileri,0);
  analogWrite(motor1_geri,0);
  analogWrite(motor2_geri,0);
  analogWrite(motor3_geri,0);
  analogWrite(motor4_geri,0);
}


