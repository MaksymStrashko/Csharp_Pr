-- Завдання 1: Створення таблиці products
CREATE TABLE products (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    price DECIMAL(10, 2),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Додавання нової колонки stock
ALTER TABLE products ADD COLUMN stock INT DEFAULT 0;

-- Додавання тестових даних
INSERT INTO products (name, price, stock) VALUES
('Notebook', 150.00, 20),
('Phone', 50.00, 5),
('Headphones', 200.00, 12),
('Charger', 75.00, 7),
('PlayStation 5', 120.00, 0);

-- Завдання 2: Запити

-- 1. Вибір усіх записів із таблиці
SELECT * FROM products;

-- 2. Вибір товарів із ціною більше 100
SELECT * FROM products WHERE price > 100;

-- 3. Вибір товарів із залишком на складі більше 10
SELECT * FROM products WHERE stock > 10;

-- Завдання 3: Створення функції

-- Створення функції для вибору товарів з парним id
CREATE OR REPLACE FUNCTION GetEvenIdProducts()
RETURNS TABLE (id INT, name VARCHAR, price DECIMAL, created_at TIMESTAMP, stock INT) AS $$
BEGIN
    RETURN QUERY 
    SELECT p.id, p.name, p.price, p.created_at, p.stock
    FROM products p
    WHERE p.id % 2 = 0;
END;
$$ LANGUAGE plpgsql;

-- Виклик функції для отримання товарів з парним id
SELECT * FROM GetEvenIdProducts();
