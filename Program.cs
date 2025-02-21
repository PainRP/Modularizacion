using System.Numerics; // Se utiliza por el BigInteger

int select=1;

int selectF(){
   while (!int.TryParse(Console.ReadLine(), out select))
{
    Console.WriteLine("Introduce una opcion correcta");
}
return select;
}

float numero(float num){
    while (!float.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Introduce un numero correcto");
}
return num;
}

int numero_int(int num){
    while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Introduce un numero correcto");
}
return num;
}

void resultados(float resultados){
    Console.WriteLine("El resultado es: "+resultados);
}

float suma (float n1, float n2){
    return (float)n1+n2;
}

float resta (float n1, float n2){
    return (float)n1-n2;
}

float multiplicacion (float n1, float n2){
    return (float)n1*n2;
}

float division (float n1, float n2){
    return (float)n1/n2;
}

void calculadora(){
    int selectC=0;
    float num1=0,num2=0;

    Console.WriteLine("Ingrese el primer numero: ");
    num1 = numero(num1);
    Console.WriteLine("Ingrese el segundo numero: ");
    num2 = numero(num2);

    Console.WriteLine("Seleccione una operación: 1. Suma 2. Resta 3. Multiplicación 4. División");
    selectC = selectF();

    switch (selectC){
    case 1:
        float respuesta = suma(num1,num2);
        resultados(respuesta);
    break;
    case 2:
        float respuesta2 = resta(num1,num2);
        resultados(respuesta2);
    break;
    case 3:
        float respuesta3 = multiplicacion(num1,num2);
        resultados(respuesta3);
    break;
    case 4:
        float respuesta4 = division(num1,num2);
        resultados(respuesta4);
    break;   
    default:
        Console.WriteLine("Ingrese la opcion correcta");
    break; 
}
}

void validacion(){
    string contrasena = "1234";
    string user_constrasena;

    do{
        Console.WriteLine("Ingrese la contraseña");
        user_constrasena = Console.ReadLine();
    }
    while(contrasena != user_constrasena);

    Console.WriteLine("Acceso Concedido");
}

void num_primos(){
    int num = 0,numsq = 0;
    bool primo=true;
    Console.WriteLine("Ingrese un numero: ");
    num = numero_int(num);

    numsq = Convert.ToInt32(Math.Sqrt(num));

    for(int i = 2; i <= numsq; i++){
        if(num % i == 0){
            Console.WriteLine("Es compuesto ");
            primo = false;
        }
    }
    if (primo == true){
        Console.WriteLine("Es primo");
    } 
}

void suma_par(){
    int num = 1, suma = 0;
    while(num != 0){
        Console.WriteLine("Ingresa un numero (Para detener el ciclo ingresa un 0): ");
        num = numero_int(num);
        if (num % 2 == 0){
            suma += num;
        }
    }
    Console.WriteLine ($"La suma de los numeros pares es: {suma}");
}

void cel_fah(){
    float num=1;
    Console.WriteLine("Ingrese un Grado en Celsius: ");
    num= numero(num);

    Console.WriteLine($"La conversion es: {Math.Round(num*(9.0/5.0)+32,2)}°F");
}

void fah_cel(){
    float num=1;
    Console.WriteLine("Ingrese un Grado en Fahrenheit: ");
    num= numero(num);

    Console.WriteLine($"La conversion es: {Math.Round((num-32)*(5.0/9.0),2)}°C");
}

void conversion(){
    int select=0;
    Console.WriteLine("1. Celsius a Fahrenheit\n2. Fahrenheit a Celsius");
    select = numero_int(select);

    switch(select){
        case 1:
            cel_fah();
        break;
        case 2:
            fah_cel();
        break;
        default:
            Console.WriteLine("Ingrese una opcion valida");
        break;
    }
    
}

void contar_vocales(){
    string palabra;
    char caracter;
    int contador= 0;
    Console.WriteLine("Ingrese una palabra o frase: ");
    palabra=Console.ReadLine();
    if (palabra.Length == 0){
        Console.WriteLine("Cadena vacia");
    }else{
        for (int i = 0; i < palabra.Length; i++){
        caracter = palabra[i];

        if (caracter == 'A' || caracter == 'a' ||caracter == 'E' || caracter == 'e' || caracter == 'I' || caracter == 'i' || caracter == 'O' || caracter == 'o' || caracter == 'U' || caracter == 'u'){
            contador +=1;
            }
        }
        Console.WriteLine("La cantidad de vocales en la palabra/frase es de: "+contador);
    }
    
    
}

void factorial(){
    int num=0;
    Console.WriteLine("Ingrese un numero: ");
    num = numero_int(num);
    BigInteger factorial = 1; // Se utilza BigInteger para no tener un limite claro, me toco esperar unos segudos para el factorial de 100000
    for(int i = 1; i <= num; i++){
        factorial *=i;
        
    }
    Console.WriteLine("El factorial es "+factorial);
}

void adivinanza(){
    Random random = new Random();
    int numeroAleatorio = random.Next(1, 101);
    int num;
    do {
        Console.WriteLine("Adivina el numero entre 1 y 100: ");
        num = numero_int(0);
        if (num > numeroAleatorio) {
            Console.WriteLine("El número es menor");
        } else if (num < numeroAleatorio) {
            Console.WriteLine("El número es mayor");
        } else {
            Console.WriteLine("¡Felicidades! Adivinaste el número");
        }
    } while (num != numeroAleatorio);
}

void paso_referencia(){
    float num1 = 0, num2 = 0;

    Console.WriteLine("Ingrese el primer numero: ");
    num1 = numero(num1);
    Console.WriteLine("Ingrese el segundo numero: ");
    num2 = numero(num2);

    Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");

    float temp = num1;
    num1 = num2;
    num2 = temp;

    Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
}

void tablas(){
    int num = 0;
    Console.WriteLine("Ingrese un numero: ");
    num = numero_int(num);

    for(int i = 1;i <= 10; i++ ){
        Console.WriteLine($"{num} x {i} = {num*i}");
    }
}

do{
    Console.Clear();
    Console.WriteLine("1. Calculadora basica\n2. Validacion de contraseña\n3. Numeros Primos\n4. Suma de numeros pares\n5. Conversion de temperatura\n6.Contador de vocales\n7. Calculo de factorial\n8. Juego de adivinanza\n9. Paso por referencia\n10. Tabla de multiplicar\n0. Salir");
    selectF();

    switch(select){
        case 0:
        break;
        case 1:
            calculadora();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        case 2:
            validacion();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        case 3:
            num_primos();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        case 4:
            suma_par();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        case 5:
            conversion();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        case 6:
            contar_vocales();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        case 7:
            factorial();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        case 8:
            adivinanza();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        case 9:
            paso_referencia();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        case 10:
            tablas();
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
        break;
        default:
        Console.WriteLine("Seleccióne una opción correcta");
        
        break;
    }
}
while(select!=0);