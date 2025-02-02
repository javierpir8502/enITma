-- 1) Obtener los datos completos de los empleados.
SELECT * FROM empleado;

-- 2) Obtener los datos completos de los departamentos.
SELECT * FROM departamento;

-- 3) Obtener los datos de los empleados con cargo 'Secretaria'.
SELECT * FROM empleado WHERE cargoE = 'Secretaria';

-- 4) Obtener el nombre y salario de los empleados.
SELECT nomEmp, salEmp FROM empleado;

-- 5) Obtener los datos de los empleados vendedores, ordenado por nombre.
SELECT * FROM empleado WHERE cargoE = 'Vendedor' ORDER BY nomEmp;

-- 6) Listar el nombre de los departamentos.
SELECT nombreDpto FROM departamento;

-- 7) Listar el nombre de los departamentos, ordenado por nombre.
SELECT nombreDpto FROM departamento ORDER BY nombreDpto;

-- 8) Listar el nombre de los departamentos, ordenado por ciudad.
SELECT nombreDpto FROM departamento ORDER BY ciudad;

-- 9) Listar el nombre de los departamentos, ordenado por ciudad, en orden inverso.
SELECT nombreDpto FROM departamento ORDER BY ciudad DESC;

-- 10) Obtener el nombre y cargo de todos los empleados, ordenado por salario.
SELECT nomEmp, cargoE FROM empleado ORDER BY salEmp;

-- 11) Obtener el nombre y cargo de todos los empleados, ordenado por cargo y por salario.
SELECT nomEmp, cargoE FROM empleado ORDER BY cargoE, salEmp;

-- 12) Obtener el nombre y cargo de todos los empleados, en orden inverso por cargo.
SELECT nomEmp, cargoE FROM empleado ORDER BY cargoE DESC;

-- 13) Listar los salarios y comisiones de los empleados del departamento 2000.
SELECT salEmp, comisionE FROM empleado WHERE codDepto = 2000;

-- 14) Listar los salarios y comisiones de los empleados del departamento 2000, ordenado por comisión.
SELECT salEmp, comisionE FROM empleado WHERE codDepto = 2000 ORDER BY comisionE;

-- 15) Listar todas las comisiones.
SELECT comisionE FROM empleado;

-- 16) Listar las comisiones que sean diferentes, ordenadas por valor.
SELECT DISTINCT comisionE FROM empleado ORDER BY comisionE;

-- 17) Listar los diferentes salarios.
SELECT DISTINCT salEmp FROM empleado;

-- 18) Obtener el valor total a pagar que resulta de sumar a los empleados del departamento 3000 una bonificación de $500.000, en orden alfabético del empleado.
SELECT nomEmp, salEmp + 500000 AS total_pagar FROM empleado WHERE codDepto = 3000 ORDER BY nomEmp;

-- 19) Obtener la lista de los empleados que ganan una comisión superior a su sueldo.
SELECT * FROM empleado WHERE comisionE > salEmp;

-- 20) Listar los empleados cuya comisión es menor o igual que el 30% de su sueldo.
SELECT * FROM empleado WHERE comisionE <= salEmp * 0.3;

-- 21) Elabore un listado donde para cada fila, figure ‘Nombre’ y ‘Cargo’ antes del valor respectivo para cada empleado.
SELECT CONCAT('Nombre: ', nomemp, ', Cargo: ', cargoE) AS Detalle FROM empleado;

-- 22) Hallar el salario y la comisión de aquellos empleados cuyo número de documento de identidad es superior al '19.709.802'.
SELECT salemp, comisionE FROM empleado WHERE nDIEmp > '19.709.802';

-- 23) Listar los empleados cuyo salario es menor o igual que el 40% de su comisión.
SELECT * FROM empleado WHERE salEmp <= comisionE * 0.4;

-- 24) Divida los empleados, generando un grupo cuyo nombre inicie por la letra J y termine en la letra Z.
SELECT * FROM empleado WHERE nomEmp LIKE 'J%Z';

-- 25) Liste estos empleados y su cargo por orden alfabético.
SELECT nomEmp, cargoE FROM empleado WHERE nomEmp LIKE 'J%Z' ORDER BY nomEmp;

-- 26) Listar el salario, la comisión, el salario total (salario + comisión), documento de identidad del empleado y nombre, de aquellos empleados que tienen comisión superior a $1.000.000, ordenar el informe por el número del documento de identidad.
SELECT nomEmp, nDIEmp, salEmp, comisione, (salEmp + comisionE) AS salario_total
FROM empleado
WHERE comisionE > 1000000
ORDER BY nDIEmp;

-- 27) Obtener un listado similar al anterior, pero de aquellos empleados que NO tienen comisión.
SELECT nomEmp, nDIEmp, salEmp, comisionE, (salEmp + comisionE) AS salario_total
FROM empleado
WHERE comisionE IS NULL OR comisionE = 0
ORDER BY nDIEmp;

-- 28) Hallar el nombre de los empleados que tienen un salario superior a $1.000.000 y tienen como jefe al empleado con documento de identidad '31.840.269'.
SELECT nomEmp FROM empleado WHERE salEmp > 1000000 AND jefeID = '31.840.269';

-- 29) Hallar el conjunto complementario del resultado del ejercicio anterior.
SELECT nomEmp FROM empleado WHERE NOT (salEmp > 1000000 AND jefeID = '31.840.269');

-- 30) Hallar los empleados cuyo nombre no contiene la cadena “MA”.
SELECT * FROM empleado WHERE nomEmp NOT LIKE '%MA%';

-- 31) Obtener los nombres de los departamentos que no sean “Ventas” ni “Investigación” ni ‘MANTENIMIENTO’, ordenados por ciudad.
SELECT nombreDpto FROM departamento WHERE nombreDpto NOT IN ('Ventas', 'Investigación', 'MANTENIMIENTO') ORDER BY ciudad;
