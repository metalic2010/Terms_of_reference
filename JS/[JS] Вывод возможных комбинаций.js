var mas = ['Аристократ',
           'Заныть',
           'Космос',
           'Наколдовать'];

function getCombination(massiv) {
  //оставляем уникальные значения
  arr = [...massiv.filter((item, i) => i === massiv.indexOf(item))]

  //массив для результата
  let results = []

  //рекурсивная функция для проверки всех вхождений
  function recFun(arr, memo = []) {
    //циклом проходим по каждому элементу
    for (let i = 0; i < arr.length; i++) {
      //создаём новый массив без 1 элемента
      //при этом удаляем из основного массива элемент
      let cur = arr.splice(i, 1);

      //проверяем входит ли блок в результат или нет
      //нам нужны только уникальные комбинации
      //если вхождение не подтверждается, то записываем в результат
      if (arr.length === 0) {
        results.push(memo.concat(cur));
      }

      //запускаем рекурсию и передаём предыдущей результат         
      recFun(arr.slice(), memo.concat(cur));

      //возвращаем в массив забранный элемент
      arr.splice(i, 0, cur[0]);

    }
  }

  recFun(arr);

  return results;
}

console.log(getCombination(mas));