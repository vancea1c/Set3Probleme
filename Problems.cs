namespace FP_Setul3 {
    public static class Problems {
        public static int lastRun { get; private set; }
        public static void runProblem( int problemNr ) {
            lastRun = problemNr;
            switch( problemNr ) {
                case 1:
                    P1();
                    break;
                case 2:
                    P2();
                    break;
                case 3:
                    P3();
                    break;
                case 4:
                    P4();
                    break;
                case 5:
                    P5();
                    break;
                case 6:
                    P6();
                    break;
                case 7:
                    P7();
                    break;
                case 8:
                    P8();
                    break;
                case 9:
                    P9();
                    break;
                case 10:
                    P10();
                    break;
                case 11:
                    P11();
                    break;
                case 12:
                    P12();
                    break;
                case 13:
                    P13();
                    break;
                case 14:
                    P14();
                    break;
                case 15:
                    P15();
                    break;
                case 16:
                    P16();
                    break;
                case 17:
                    P17();
                    break;
                case 18:
                    P18();
                    break;
                case 19:
                    P19();
                    break;
                case 20:
                    P20();
                    break;
                case 21:
                    P21();
                    break;
                case 22:
                    P22();
                    break;
                case 23:
                    P23();
                    break;
                case 24:
                    P24();
                    break;
                case 25:
                    P25();
                    break;
                case 26:
                    P26();
                    break;
                case 27:
                    P27();
                    break;
                case 28:
                    P28();
                    break;
                case 29:
                    P29();
                    break;
                case 30:
                    P30();
                    break;
                case 31:
                    P31();
                    break;
                default:
                    throw new Exception("pb_nr_outOfRange");
            }
        }

        private static void P1() {
            Console.WriteLine("1.Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.\n");
            int[] array = ArrayHelpers.getArray();
            int sum = 0;
            foreach( int element in array ) {
                sum += element;
            }
            Console.WriteLine($"Suma elementelor este {sum}.");
        }

        private static void P2() {
            Console.WriteLine("2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k.\nDaca k nu apare in vector rezultatul va fi -1.\n");
            int[] array = ArrayHelpers.getArray();
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            int position = -1;
            for( int i = 0; i < array.Length; i++ ) {
                if( array[i] == k ) {
                    position = i;
                    break;
                }
            }
            Console.WriteLine(position == -1 ? $"{k} nu se afla in vector." : $"Prima pozitie pe care se gaseste {k} este {position}.");
        }

        private class MinMax {

            public int min;
            public int max;
            public int minCount;
            public int maxCount;

            public MinMax() {
                minCount = 0;
                maxCount = 0;
            }
        }
        private static MinMax getMinMax( int[] array, int low, int high ) {
            int mid;
            MinMax values = new MinMax();
            MinMax valuesLeft = new MinMax();
            MinMax valuesRight = new MinMax();

            if( low == high ) {
                values.max = array[low];
                values.min = array[low];
                return values;
            }

            if( high == low + 1 ) {
                if( array[low] > array[high] ) {
                    values.max = array[low];
                    values.min = array[high];
                } else {
                    values.max = array[high];
                    values.min = array[low];
                }
                return values;
            }

            mid = ( low + high ) / 2;
            valuesLeft = getMinMax(array, low, mid);
            valuesRight = getMinMax(array, mid + 1, high);

            if( valuesLeft.min < valuesRight.min ) {
                values.min = valuesLeft.min;
            } else {
                values.min = valuesRight.min;
            }

            if( valuesLeft.max > valuesRight.max ) {
                values.max = valuesLeft.max;
            } else {
                values.max = valuesRight.max;
            }

            return values;

        }
        private static void P3() {
            Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.\nPentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).\n");
            int[] array = ArrayHelpers.getArray();
            MinMax values = getMinMax(array, 0, array.Length - 1);
            Console.WriteLine($"Max: {values.max} | Min: {values.min} ");

        }

        private static void P4() {
            Console.WriteLine("4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.\n");
            int[] array = ArrayHelpers.getArray();
            MinMax values = new();
            values.min = array[0];
            values.max = array[0];
            for( int i = 0; i < array.Length; i++ ) {
                if( array[i] > values.max ) {
                    values.max = array[i];
                    values.maxCount = 1;
                } else if( array[i] < values.min ) {
                    values.min = array[i];
                    values.minCount = 1;
                } else {
                    if( array[i] == values.min )
                        values.minCount++;
                    if( array[i] == values.max )
                        values.maxCount++;
                }
            }

            Console.WriteLine($"Min: {values.min}, Count: {values.minCount}");
            Console.WriteLine($"Max: {values.max}, Count: {values.maxCount}");
        }
        private static void P5() {
            Console.WriteLine("5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k.\nPrimul element al vectorului se considera pe pozitia zero.\n");
            int[] array = ArrayHelpers.getArray();
            Console.Write("Enter e: ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length + 1];
            for( int i = 0; i < array.Length; i++ ) {
                newArray[i] = array[i];
            }
            for( int i = newArray.Length - 1; i > k; i-- ) {
                newArray[i] = newArray[i - 1];
            }
            newArray[k] = e;
            Console.WriteLine("New array: ");
            ArrayHelpers.printArray(newArray);
        }
        private static void P6() {
            Console.WriteLine("6.Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.\nPrin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.\n");
            int[] array = ArrayHelpers.getArray();
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length - 1];
            for( int i = 0; i < k; i++ ) {
                newArray[i] = array[i];
            }
            for( int i = k; i < newArray.Length; i++ ) {
                newArray[i] = array[i + 1];
            }
            Console.WriteLine("New array: ");
            ArrayHelpers.printArray(newArray);
        }
        private static void P7() {
            Console.WriteLine("7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.\nPrin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.\n");
            int[] array = ArrayHelpers.getArray();
            int[] newArray = new int[array.Length];
            for( int i = 0; i < array.Length; i++ ) {
                newArray[i] = array[array.Length - i - 1];
            }
            Console.WriteLine("New array: ");
            ArrayHelpers.printArray(newArray);
        }
        private static void P8() {
            Console.WriteLine("8.Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.\nPrin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.\n");
            int[] array = ArrayHelpers.getArray();
            int[] newArray = new int[array.Length];
            newArray[0] = array[array.Length - 1];
            for( int i = 1; i < array.Length; i++ ) {
                newArray[i] = array[i - 1];
            }
            Console.WriteLine("New array: ");
            ArrayHelpers.printArray(newArray);
        }
        private static void P9() {
            Console.WriteLine("9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
            int[] array = ArrayHelpers.getArray();
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length];
            for( int i = 0; i < array.Length; i++ ) {
                newArray[i] = array[( i + k ) % array.Length];
            }
            Console.WriteLine("New array: ");
            ArrayHelpers.printArray(newArray);
        }
        private static void P10() {
            Console.WriteLine("10.Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k.\nDaca elementul nu se gaseste in vector rezultatul va fi -1.\n");
            int[] array = ArrayHelpers.getArray();
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            int left = 0;
            int right = array.Length - 1;
            int mid = ( left + right ) / 2;
            while( left <= right ) {
                if( array[mid] == k ) {
                    Console.WriteLine($"Element found at index {mid}.");
                    return;
                } else if( array[mid] < k ) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
                mid = ( left + right ) / 2;
            }
            Console.WriteLine("Element not found.");

        }
        private static void P11() {
            Console.WriteLine("11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).\n");
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n + 1];
            for( int i = 2; i <= n; i++ ) {
                isPrime[i] = true;
            }
            for( int i = 2; i <= n; i++ ) {
                if( isPrime[i] ) {
                    for( int j = i * i; j <= n; j += i ) {
                        isPrime[j] = false;
                    }
                }
            }
            Console.WriteLine("Prime numbers: ");
            for( int i = 2; i <= n; i++ ) {
                if( isPrime[i] ) {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
        private static void P12() {
            Console.WriteLine("12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.\n");
            int[] array = ArrayHelpers.getArray();
            for( int i = 0; i < array.Length - 1; i++ ) {
                int min = i;
                for( int j = i + 1; j < array.Length; j++ ) {
                    if( array[j] < array[min] ) {
                        min = j;
                    }
                }
                int aux = array[i];
                array[i] = array[min];
                array[min] = aux;
            }
            Console.WriteLine("Sorted array: ");
            ArrayHelpers.printArray(array);
        }
        private static void P13() {
            Console.WriteLine("13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.\n");
            int[] array = ArrayHelpers.getArray();
            for( int i = 1; i < array.Length; i++ ) {
                int j = i - 1;
                int aux = array[i];
                while( j >= 0 && array[j] > aux ) {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = aux;
            }
            Console.WriteLine("Sorted array: ");
            ArrayHelpers.printArray(array);
        }
        private static void P14() {
            Console.WriteLine("14.Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.\n(nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient -\nse va face o singura parcugere a vectorului).\n");
            int[] array = ArrayHelpers.getArray();
            int left = 0;
            int right = array.Length - 1;
            while( left < right ) {
                if( array[left] == 0 ) {
                    int aux = array[left];
                    array[left] = array[right];
                    array[right] = aux;
                    right--;
                } else {
                    left++;
                }
            }
            Console.WriteLine("New array: ");
            ArrayHelpers.printArray(array);
        }
        private static void P15() {
            Console.WriteLine("15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.");
            int[] array = ArrayHelpers.getArray();
            int left = 0;
            int right = 1;
            while( right < array.Length ) {
                if( array[left] == array[right] ) {
                    right++;
                } else {
                    left++;
                    array[left] = array[right];
                    right++;
                }
            }
            Console.WriteLine("New array: ");
            ArrayHelpers.printArray(array);
        }
        private static int Cmmdc( int a, int b ) {
            if( b == 0 ) {
                return a;
            }
            return Cmmdc(b, a % b);
        }
        private static void P16() {
            Console.WriteLine("16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.\n");
            int[] array = ArrayHelpers.getArray();
            int cmmdc = array[0];
            for( int i = 1; i < array.Length; i++ ) {
                cmmdc = Cmmdc(cmmdc, array[i]);
            }
            Console.WriteLine($"GCD: {cmmdc}");

        }
        private static void P17() {
            Console.WriteLine("17.Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.\n");
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            if( b <= 1 && b >= 17 )
                throw new Exception("P17_invalid_base");
            string result = "";
            while( n > 0 ) {
                int digit = n % b;
                if( digit < 10 ) {
                    result = digit + result;
                } else {
                    result = (char)( digit + 55 ) + result;
                }
                n /= b;
            }
            Console.WriteLine($"Result: {result}");
        }
        private static void P18() {
            Console.WriteLine("18.Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector.\nSe cere valoarea polinomului intr-un punct x.\n");
            int[] array = ArrayHelpers.getArray();
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            int result = 0;
            for( int i = 0; i < array.Length; i++ ) {
                result += array[i] * (int)Math.Pow(x, i);
            }
            Console.WriteLine($"Result: {result}");
        }
        private static void P19() {
            Console.WriteLine("19,Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s.\nDe ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.\n");
            int[] s = ArrayHelpers.getArray();
            Console.WriteLine("Vector P:");
            int[] p = ArrayHelpers.getArray();
            int count = 0;
            for( int i = 0; i < s.Length; i++ ) {
                if( s[i] == p[0] ) {
                    bool found = true;
                    for( int j = 1; j < p.Length; j++ ) {
                        if( s[i + j] != p[j] ) {
                            found = false;
                            break;
                        }
                    }
                    if( found ) {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Count: {count}");
        }
        private static void P20() {
            Console.WriteLine("20.Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.\nSiragurile de margele se pot roti atunci cand le suprapunem.\n");
            Console.WriteLine("Sirag 1:");
            int[] s1 = ArrayHelpers.getArray();
            Console.WriteLine("Sirag 2:");
            int[] s2 = ArrayHelpers.getArray();
            int count = 0;
            for( int i = 0; i < s1.Length; i++ ) {
                for( int j = 0; j < s2.Length; j++ ) {
                    if( s1[i] == s2[j] ) {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Count: {count}");
        }
        private static void P21() {
            Console.WriteLine("21.Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).\n");
            Console.WriteLine("Vector 1:");
            int[] v1 = ArrayHelpers.getArray();
            Console.WriteLine("Vector 2:");
            int[] v2 = ArrayHelpers.getArray();
            int i = 0;
            while( i < v1.Length && i < v2.Length ) {
                if( v1[i] < v2[i] ) {
                    Console.WriteLine("Vector 1");
                    return;
                } else if( v1[i] > v2[i] ) {
                    Console.WriteLine("Vector 2");
                    return;
                }
                i++;
            }
            if( i == v1.Length ) {
                Console.WriteLine("Vector 2");
            } else {
                Console.WriteLine("Vector 1");
            }

        }
        private static void P22() {
            Console.WriteLine("22.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi).\nElementele care se repeta vor fi scrise o singura data in rezultat.\n");
            Console.WriteLine("Vector 1:");
            int[] v1 = ArrayHelpers.getArray();
            Console.WriteLine("Vector 2:");
            int[] v2 = ArrayHelpers.getArray();
            int[] intersection = new int[v1.Length + v2.Length];
            int[] union = new int[v1.Length + v2.Length];
            int[] difference1 = new int[v1.Length];
            int[] difference2 = new int[v2.Length];
            int intersectionCount = 0;
            int unionCount = 0;
            int difference1Count = 0;
            int difference2Count = 0;
            for( int i = 0; i < v1.Length; i++ ) {
                bool found = false;
                for( int j = 0; j < v2.Length; j++ ) {
                    if( v1[i] == v2[j] ) {
                        found = true;
                        break;
                    }
                }
                if( found ) {
                    intersection[intersectionCount++] = v1[i];
                } else {
                    difference1[difference1Count++] = v1[i];
                }
                union[unionCount++] = v1[i];
            }
            for( int i = 0; i < v2.Length; i++ ) {
                bool found = false;
                for( int j = 0; j < v1.Length; j++ ) {
                    if( v2[i] == v1[j] ) {
                        found = true;
                        break;
                    }
                }
                if( !found ) {
                    difference2[difference2Count++] = v2[i];
                }
                union[unionCount++] = v2[i];
            }
            intersection = intersection.Take(intersectionCount).ToArray();
            union = union.Take(unionCount).Distinct().ToArray();
            difference1 = difference1.Take(difference1Count).ToArray();
            difference2 = difference2.Take(difference2Count).ToArray();
            Console.WriteLine("Intersection:");
            ArrayHelpers.printArray(intersection);
            Console.WriteLine("Union:");
            ArrayHelpers.printArray(union);
            Console.WriteLine("Difference 1:");
            ArrayHelpers.printArray(difference1);
            Console.WriteLine("Difference 2:");
            ArrayHelpers.printArray(difference2);
        }
        private static void P23() {
            Console.WriteLine("23.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2 sunt in ordine strict crescatoare.\n");
            Console.WriteLine("Vector 1:");
            int[] v1 = ArrayHelpers.getArray();
            Console.WriteLine("Vector 2:");
            int[] v2 = ArrayHelpers.getArray();
            int[] intersection = new int[v1.Length + v2.Length];
            int[] union = new int[v1.Length + v2.Length];
            int[] difference1 = new int[v1.Length];
            int[] difference2 = new int[v2.Length];
            int intersectionCount = 0;
            int unionCount = 0;
            int difference1Count = 0;
            int difference2Count = 0;
            int i = 0;
            int j = 0;
            while( i < v1.Length && j < v2.Length ) {
                if( v1[i] == v2[j] ) {
                    intersection[intersectionCount++] = v1[i];
                    union[unionCount++] = v1[i];
                    i++;
                    j++;
                } else if( v1[i] < v2[j] ) {
                    difference1[difference1Count++] = v1[i];
                    union[unionCount++] = v1[i];
                    i++;
                } else {
                    difference2[difference2Count++] = v2[j];
                    union[unionCount++] = v2[j];
                    j++;
                }
            }
            while( i < v1.Length ) {
                difference1[difference1Count++] = v1[i];
                union[unionCount++] = v1[i];
                i++;
            }
            while( j < v2.Length ) {
                difference2[difference2Count++] = v2[j];
                union[unionCount++] = v2[j];
                j++;
            }
            intersection = intersection.Take(intersectionCount).ToArray();
            union = union.Take(unionCount).ToArray();
            difference1 = difference1.Take(difference1Count).ToArray();
            difference2 = difference2.Take(difference2Count).ToArray();
            Console.WriteLine("Intersection:");
            ArrayHelpers.printArray(intersection);
            Console.WriteLine("Union:");
            ArrayHelpers.printArray(union);
            Console.WriteLine("Difference 1:");
            ArrayHelpers.printArray(difference1);
            Console.WriteLine("Difference 2:");
            ArrayHelpers.printArray(difference2);
        }
        private static void P24() {
            Console.WriteLine("24.Aceleasi cerinte ca si la problema anterioara, dar de data asta elementele sunt stocate ca vectori cu valori binare\n(v[i] este 1 daca i face parte din multime si este 0 in caz contrar).\n");
            Console.WriteLine("Vector 1:");
            int[] v1 = ArrayHelpers.getArray();
            Console.WriteLine("Vector 2:");
            int[] v2 = ArrayHelpers.getArray();
            int[] intersection = new int[v1.Length + v2.Length];
            int[] union = new int[v1.Length + v2.Length];
            int[] difference1 = new int[v1.Length];
            int[] difference2 = new int[v2.Length];
            int intersectionCount = 0;
            int unionCount = 0;
            int difference1Count = 0;
            int difference2Count = 0;
            for( int i = 0; i < v1.Length; i++ ) {
                if( v1[i] == 1 && v2[i] == 1 ) {
                    intersection[intersectionCount++] = 1;
                } else {
                    intersection[intersectionCount++] = 0;
                }
                if( v1[i] == 1 || v2[i] == 1 ) {
                    union[unionCount++] = 1;
                } else {
                    union[unionCount++] = 0;
                }
                if( v1[i] == 1 && v2[i] == 0 ) {
                    difference1[difference1Count++] = 1;
                } else {
                    difference1[difference1Count++] = 0;
                }
                if( v1[i] == 0 && v2[i] == 1 ) {
                    difference2[difference2Count++] = 1;
                } else {
                    difference2[difference2Count++] = 0;
                }
            }
            intersection = intersection.Take(intersectionCount).ToArray();
            union = union.Take(unionCount).ToArray();
            difference1 = difference1.Take(difference1Count).ToArray();
            difference2 = difference2.Take(difference2Count).ToArray();
            Console.WriteLine("Intersection:");
            ArrayHelpers.printArray(intersection);
            Console.WriteLine("Union:");
            ArrayHelpers.printArray(union);
            Console.WriteLine("Difference 1:");
            ArrayHelpers.printArray(difference1);
            Console.WriteLine("Difference 2:");
            ArrayHelpers.printArray(difference2);
        }
        private static void P25() {
            Console.WriteLine("25.(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.\nSunt permise elemente duplicate.\n");
            Console.WriteLine("Vector 1:");
            int[] v1 = ArrayHelpers.getArray();
            Console.WriteLine("Vector 2:");
            int[] v2 = ArrayHelpers.getArray();
            int[] v3 = new int[v1.Length + v2.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while( i < v1.Length && j < v2.Length ) {
                if( v1[i] < v2[j] ) {
                    v3[k++] = v1[i++];
                } else {
                    v3[k++] = v2[j++];
                }
            }
            while( i < v1.Length ) {
                v3[k++] = v1[i++];
            }
            while( j < v2.Length ) {
                v3[k++] = v2[j++];
            }
            v3 = v3.Take(k).ToArray();
            Console.WriteLine("Result:");
            ArrayHelpers.printArray(v3);

        }

        public static int[] SumDigitArrays( int[] a, int[] b ) {
            int length = Math.Max(a.Length, b.Length);
            var result = new int[length];

            for( int i = 0; i < length; i++ ) {
                int lhs = ( i < a.Length ) ? a[i] : 0;
                int rhs = ( i < b.Length ) ? b[i] : 0;

                int sum = result[i] + lhs + rhs;
                result[i] = sum % 10;

                int carry = sum / 10;

                if( i + 1 < result.Length ) {
                    result[i + 1] = result[i + 1] + carry;
                }
            }

            return result;
        }
        private static void removeTrailingZeros( ref int[] v ) {
            int i = 0;
            while( i < v.Length && v[i] == 0 ) {
                i++;
            }
            v = v.Skip(i - 1).ToArray();

        }

        private static void P26() {
            Console.WriteLine("26.Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie).\nSe cere sa se determine suma, diferenta si produsul a doua astfel de numere.\n");
            Console.WriteLine("First number:");
            string number1 = Console.ReadLine();
            int[] n1 = new int[number1.Length];
            for( int a = 0; a < number1.Length; a++ ) {
                n1[a] = int.Parse(number1[a].ToString());
            }
            Console.WriteLine("Second number:");
            string number2 = Console.ReadLine();
            int[] n2 = new int[number2.Length];
            for( int a = 0; a < number2.Length; a++ ) {
                n2[a] = int.Parse(number2[a].ToString());
            }
            //add numbers
            int[] sum = new int[n1.Length + n2.Length];
            int i = n1.Length - 1;
            int j = n2.Length - 1;
            int k = sum.Length - 1;
            int carry = 0;
            while( i >= 0 && j >= 0 ) {
                int s = n1[i] + n2[j] + carry;
                if( s > 9 ) {
                    carry = 1;
                    s -= 10;
                } else {
                    carry = 0;
                }
                sum[k--] = s;
                i--;
                j--;
            }
            while( i >= 0 ) {
                int s = n1[i] + carry;
                if( s > 9 ) {
                    carry = 1;
                    s -= 10;
                } else {
                    carry = 0;
                }
                sum[k--] = s;
                i--;
            }
            while( j >= 0 ) {
                int s = n2[j] + carry;
                if( s > 9 ) {
                    carry = 1;
                    s -= 10;
                } else {
                    carry = 0;
                }
                sum[k--] = s;
                j--;
            }
            if( carry == 1 ) {
                sum[k--] = 1;
            }
            sum = sum.Skip(k + 1).ToArray();
            removeTrailingZeros(ref sum);
            Console.WriteLine("Sum:");
            ArrayHelpers.printArray(sum, true);
            //subtract numbers
            int[] difference = new int[n1.Length + n2.Length];
            i = n1.Length - 1;
            j = n2.Length - 1;
            k = difference.Length - 1;
            carry = 0;
            while( i >= 0 && j >= 0 ) {
                int s = n1[i] - n2[j] - carry;
                if( s < 0 ) {
                    carry = 1;
                    s += 10;
                } else {
                    carry = 0;
                }
                difference[k--] = s;
                i--;
                j--;
            }
            while( i >= 0 ) {
                int s = n1[i] - carry;
                if( s < 0 ) {
                    carry = 1;
                    s += 10;
                } else {
                    carry = 0;
                }
                difference[k--] = s;
                i--;
            }
            while( j >= 0 ) {
                int s = n2[j] - carry;
                if( s < 0 ) {
                    carry = 1;
                    s += 10;
                } else {
                    carry = 0;
                }
                difference[k--] = s;
                j--;
            }
            if( carry == 1 ) {
                difference[k--] = 1;
            }
            difference = difference.Skip(k + 1).ToArray();
            removeTrailingZeros(ref difference);
            Console.WriteLine("Difference:");
            ArrayHelpers.printArray(difference, true);
            //multiply numbers
            int length1 = Math.Max(n1.Length, n2.Length);
            int[] multiResult = new int[length1 * length1];

            for( int a = 0; a < length1; a++ ) {
                int[] PartialProduct = new int[length1 * length1];

                int length2 = Math.Min(n1.Length, n2.Length);
                for( int b = 0; b < length2; b++ ) {
                    int multiplicand = ( n1.Length < n2.Length ) ? n2[a] : n1[a];
                    int multiplier = ( n1.Length < n2.Length ) ? n1[b] : n2[b];

                    int product = PartialProduct[a + b] + multiplicand * multiplier;

                    PartialProduct[a + b] = product % 10;
                    int mCarry = product / 10;

                    PartialProduct[a + b + 1] = PartialProduct[a + b + 1] + mCarry;
                }
                multiResult = SumDigitArrays(PartialProduct, multiResult);
            }
            removeTrailingZeros(ref multiResult);
            Console.WriteLine("Product:");
            ArrayHelpers.printArray(multiResult, true);
        }

        private static void P27() {
            Console.WriteLine("27.Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.\n");
            int[] v = ArrayHelpers.getArray();
            Console.WriteLine("Index:");
            int index = int.Parse(Console.ReadLine());
            Array.Sort(v);
            Console.WriteLine("Result:");
            Console.WriteLine(v[index]);
        }

        private static int[] QuickSort( int[] array, int leftIndex, int rightIndex ) {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while( i <= j ) {
                while( array[i] < pivot ) {
                    i++;
                }

                while( array[j] > pivot ) {
                    j--;
                }

                if( i <= j ) {
                    (array[j], array[i]) = (array[i], array[j]);
                    i++;
                    j--;
                }
            }

            if( leftIndex < j )
                QuickSort(array, leftIndex, j);

            if( i < rightIndex )
                QuickSort(array, i, rightIndex);

            return array;
        }
        private static void P28() {
            Console.WriteLine("28.Quicksort. Sortati un vector folosind metoda QuickSort.\n");
            int[] v = ArrayHelpers.getArray();
            int[] sortedArray = QuickSort(v, 0, v.Length - 1);
            Console.WriteLine("Sorted array:");
            ArrayHelpers.printArray(sortedArray);
        }

        private static int[] MergeSort( int[] array, int leftIndex, int rightIndex ) {
            if( leftIndex < rightIndex ) {
                int middleIndex = ( leftIndex + rightIndex ) / 2;
                MergeSort(array, leftIndex, middleIndex);
                MergeSort(array, middleIndex + 1, rightIndex);
                Merge(array, leftIndex, middleIndex, rightIndex);
            }
            return array;
        }

        private static void Merge( int[] array, int leftIndex, int middleIndex, int rightIndex ) {
            int[] leftArray = new int[middleIndex - leftIndex + 1];
            int[] rightArray = new int[rightIndex - middleIndex];
            for( int i = 0; i < leftArray.Length; i++ ) {
                leftArray[i] = array[leftIndex + i];
            }
            for( int i = 0; i < rightArray.Length; i++ ) {
                rightArray[i] = array[middleIndex + 1 + i];
            }
            int i1 = 0;
            int i2 = 0;
            int k = leftIndex;
            while( i1 < leftArray.Length && i2 < rightArray.Length ) {
                if( leftArray[i1] <= rightArray[i2] ) {
                    array[k++] = leftArray[i1++];
                } else {
                    array[k++] = rightArray[i2++];
                }
            }
            while( i1 < leftArray.Length ) {
                array[k++] = leftArray[i1++];
            }
            while( i2 < rightArray.Length ) {
                array[k++] = rightArray[i2++];
            }
        }

        private static void P29() {
            Console.WriteLine("29.MergeSort. Sortati un vector folosind metoda MergeSort.\n");
            int[] array = ArrayHelpers.getArray();
            int[] sortedArray = MergeSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array:");
            ArrayHelpers.printArray(sortedArray);
        }
        private static void P30() {
            Console.WriteLine("30.Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i].\nSortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.\n");
            Console.WriteLine("Vector E:");
            int[] E = ArrayHelpers.getArray();
            Console.WriteLine("Vector W:");
            int[] W = ArrayHelpers.getArray();
            int[] sortedE = MergeSort(E, 0, E.Length - 1);
            int[] sortedW = new int[W.Length];
            for( int i = 0; i < sortedE.Length; i++ ) {
                for( int j = 0; j < E.Length; j++ ) {
                    if( sortedE[i] == E[j] ) {
                        sortedW[i] = W[j];
                    }
                }
            }
            Console.WriteLine("Sorted E:");
            ArrayHelpers.printArray(sortedE);
            Console.WriteLine("Sorted W:");
            ArrayHelpers.printArray(sortedW);
        }
        private static void P31() {
            Console.WriteLine("31.(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2\ndin valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).\nSa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>).\n");
            int[] v = ArrayHelpers.getArray();
            int[] sortedV = MergeSort(v, 0, v.Length - 1);
            int count = 1;
            int majoritate = 0;
            for( int i = 0; i < sortedV.Length - 1; i++ ) {
                if( sortedV[i] == sortedV[i + 1] ) {
                    count++;
                } else {
                    count = 1;
                }
                if( count > sortedV.Length / 2 ) {
                    majoritate = sortedV[i];
                }
            }
            if( majoritate != 0 ) {
                Console.WriteLine("Majoritatea este: " + majoritate);
            } else {
                Console.WriteLine("Nu exista majoritate");
            }
        }
    }
}
