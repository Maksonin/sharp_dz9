// метод для вывода запроса в консоль на ввод числа и чтение числа из консоли
int Input(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Task64(){
    // Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    int m = Input("Введите M");
    int n = Input("Введите N");

    while ( m <= n ){
        if( m % 3 == 0)
            Console.WriteLine($"{m} - кратно 3");
        m++;
    }
}

void Task66(){
    // Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
    int m = Input("Введите M");
    int n = Input("Введите N");

    void Rec(int m, int n){
        if(m > n) return;

        if( m % 3 == 0)
            Console.WriteLine($"{m} - кратно 3");
        
        m++;

        Rec(m, n);
    }

    Rec(m,n);
}

void Task68(){
    // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    //          | n + 1; m = 0
    // A(m,n) = | A(m-1,1); n = 0
    //          | A(m-1,A(m,n - 1)); m,n > 0
    int m = 3;
    int n = 2;

    int A(int m, int n){
        if(m==0)
            return n+1;
        else if (n==0)
            return A(m - 1, 1);
        else
            return A(m - 1, A(m, n - 1));
    }

    Console.WriteLine($"Решение функции Аккермана = {A(m,n)}");
}

// метод для вывода меню выбора задач
void Menu() {
    Console.WriteLine("1 - Задача 64");
    Console.WriteLine("2 - Задача 66");
    Console.WriteLine("3 - Задача 68");

    switch (Input("Введите номер задачи - ")){
        case 1:
            Task64();
            break;
        case 2:
            Task66();
            break;
        case 3:
            Task68();
            break;
        default:
            Console.WriteLine("Задачи с таким номером не существует");
            break;
    }
}

Menu();