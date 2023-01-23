/*
	В базе данных MS SQL Server есть продукты и категории.
    Одному продукту может соответствовать много категорий,
    в одной категории может быть много продуктов.
    Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
    Если у продукта нет категорий, то его имя все равно должно выводиться.
*/

/*
  Перечень продуктов 
*/
CREATE TABLE [dbo].[Products] (
  [id] int IDENTITY (1,1) NOT NULL,
  [ProductId] int NOT NULL,
  [CategoryId] int,
  [DateCreated] date NOT NULL,
  [productName] varchar(50) NOT NULL,
  [description] varchar(250)
);

/*
  Перечень категорий
*/
CREATE TABLE [dbo].[Category] (
  [CategoryId] int NOT NULL UNIQUE,
  [DateCreated] date NOT NULL,
  [categoryName] varchar(50) NOT NULL,
  [description] varchar(250)
);

INSERT INTO [dbo].[Products] (
  [ProductId],
  [CategoryId],
  [DateCreated],
  [productName],
  [description]
)
VALUES
    (1, 1, '19911210', 'Book1', 'Интересная книга'),
    (2, 1, '20000218', 'Book2', 'Просто книга'),
    (3, null, '20100315', 'Book3', 'Странная книга'),
    (4, 2, '20220520', 'Journal1', 'Смешной'),
    (5, 2, '20230123', 'Journal2', 'Инвесторский'),
    (6, 3, '20150814', 'Film1', 'Боевик'),
    (7, 2, '20150814', 'Video Journal', 'видео журнал'),
    (7, 3, '20150814', 'Video Journal', 'видео журнал'),
    (8, 1, '20000218', 'Video book', 'видео книга'),
    (8, 3, '20000218', 'Video book', 'видео книга')
;

INSERT INTO [dbo].[Category] (
  [CategoryId],
  [DateCreated],
  [categoryName],
  [description]
)
VALUES
    (1, '19911210', 'Books', '----- Books -----'),
    (2, '20000218', 'Journals', '----- Journals -----'),
    (3, '20100315', 'Video cassette', '----- Video cassette -----')
;

/*
    Вывод всех продуктов с категориями
    Если у продукта более 1 категории, то они отобразяться в одной строке
    Если у продукта категория не найдена, то выведется "Category not found"
*/
SELECT p.[productName],
  ISNULL(STRING_AGG(cat.[categoryName], ', '), 'Category not found') as [categoryName]
FROM [dbo].[Products] as p
LEFT JOIN (
  SELECT DISTINCT [CategoryId],
    [categoryName]
  FROM [dbo].[Category]
) as cat
ON p.[CategoryId] = cat.[CategoryId]
GROUP BY p.[productName]
ORDER BY p.[productName]