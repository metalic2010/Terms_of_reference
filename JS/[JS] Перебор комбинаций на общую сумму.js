/**
* Написать функцию sostavChisla(massivChisel: number[], chislo: number), 
  которая бы находила все возможные комбинации чисел из massivChisel, 
  сумма которых равна chislo. При этом:
  1) massivChisel содержит, только уникальные положительные числа (> 0)
  2) в комбинации не должно быть повторений чисел
  3) все комбинации должны быть уникальными
  
  Для проверки работоспособности функции запустить runTests()
  
  @param massivChisel: number[]
  @param chislo: number[]
  @return Array<Array<number>>
*/
function sostavChisla(massivChisel, chislo) {
  //отбираем числа меньше заданного и оставляем уникальные значения
  arr = [...massivChisel.filter((item,i) => (item <= chislo) && (i === massivChisel.indexOf(item)))]
  
  //массив для результата
  let results = []
  
  //функция суммирования элементов
  const sumArr = (a) => {
      return a.reduce((sum, elem) => {
          return sum + elem;
      }, 0);
  }
  
  //рекурсивная функция для проверки всех вхождений
  function recFun (arr, memo = []) {
      //циклом проходим по каждому элементу
      for (let i = 0; i < arr.length; i++) {
          //создаём новый массив без 1 элемента
          //при этом удаляем из основного массива элемент
          let cur = arr.splice(i, 1);
          
          //соединяем отрезанный кусок с предыдущим результатом и сортируем
          let memoRes = memo.concat(cur).sort();
          
          //проверяем, если сумма равна числу
          if (sumArr(memoRes) === chislo)
          {
              //проверяем входит ли блок в результат или нет
              //нам нужны только уникальные комбинации
              //если вхождение не подтверждается, то записываем в результат
              if (!results.some(rItem => JSON.stringify(rItem) === JSON.stringify(memoRes))) {
                  results.push(memoRes);
              }
          }

          //запускаем рекурсию и передаём предыдущей результат         
          recFun(arr.slice(), memoRes);
          
          //возвращаем в массив забранный элемент
          arr.splice(i, 0, cur[0]);
          
      }
  }
  
  recFun(arr);
  
  return results;
}

// console.log(sostavChisla([8, 2, 3, 4, 6, 7, 1], 99));

function compareNumericArrays(arr1, arr2) {
if(arr1.length !== arr2.length) {
  return false;
}

arr1 = [...arr1].sort();
arr2 = [...arr2].sort();

for(let i=0; i<arr1.length; i++) {
  if(arr1[i] !== arr2[i]) {
    return false;
  }
}

return true;
}

function compareArraysOfNumericArrays(arr1, arr2) {
if(arr1.length !== arr2.length) {
  return false;
}

for(let el1 of arr1) {
  if(arr2.findIndex(el2 => compareNumericArrays(el1, el2)) < 0) {
    return false;
  }
}

return true;
}

runTests();

function runTests() {
  const tests = [
  {
    chislo: 5, 
    massivChisel: [8, 2, 3, 4, 6, 7, 1],
    result: [[2, 3], [4, 1]]
  },
  {
    chislo: 99, 
    massivChisel: [8, 2, 3, 4, 6, 7, 1],
    result: []
  },
  {
    chislo: 8, 
    massivChisel: [1, 2, 3, 4, 5, 6, 7, 8],
    result: [[1, 3, 4], [1, 2, 5], [3, 5], [2, 6], [1, 7], [8]]
  },
  {
    chislo: 8, 
    massivChisel: [7, 8, 3, 4, 5, 6, 1, 2],
    result: [[1, 3, 4], [1, 2, 5], [3, 5], [2, 6], [1, 7], [8]]
  },
  {
    chislo: 15, 
    massivChisel: [7, 8, 3, 4, 5, 6, 1, 2],
    result: [[1, 2, 3, 4, 5], [2, 3, 4, 6], [1, 3, 5, 6], [4, 5, 6], [1, 3, 4, 7], [1, 2, 5, 7], [3, 5, 7], [2, 6, 7], [1, 2, 4, 8], [3, 4, 8], [2, 5, 8], [1, 6, 8], [7, 8]]
  },  
  
];

let errors = 0;
for(const test of tests) {
  let result;
  try{
    result = sostavChisla(test.massivChisel, test.chislo);
    
    if(!compareArraysOfNumericArrays(
        result, 
        test.result)
    ) {
      errors++;
      console.log('--------------------------------------------')
      console.log("failed for test", test, "Got result", result);
    }
  } catch(e) {
    errors++;
    console.log("failed for", test, 'exception', e.message);
  }    
}

if(errors === 0) {
  console.log('checkStringForBracects test successfuly completed');
} else {
  console.log(`checkStringForBracects test failed with ${errors} errors`);
}
}

