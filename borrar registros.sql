DELETE FROM EVENTOS;
DELETE  FROM  EVENTOSJORNADAS;
DELETE  FROM EVENTOSUBICACIONES;
DELETE  FROM VENTASENTRADAS;
DELETE  FROM PAGOEFECTIVO;
DELETE  FROM PAGOTARJETACREDITO;
DELETE  FROM VENTASJORNADAS;
DELETE  FROM VENTASUBICACIONES;
DELETE  FROM  BOLETAS;
DELETE FROM ANULACIONVENTASPE;
DELETE FROM ANULACIONVENTASPT;
DELETE FROM CLIENTES;
DELETE FROM COMPRASCLIENTES;
DELETE FROM REGISTRACLIENTE;
--DELETE FROM PRODUCCION;
--DELETE FROM VENDEDORES;
DELETE FROM GUITARRAS;
DELETE FROM MICROFONOS;
DELETE FROM TECLADOS;
DELETE FROM ATRILES;
DELETE FROM BATERIAS;
DELETE FROM MESAS;
DELETE FROM BAJOS;
DELETE FROM AMPLIFICADORES;
DELETE FROM BAQUETAS;
DBCC CHECKIDENT (BAJOS,RESEED,0);
DBCC CHECKIDENT (AMPLIFICADORES,RESEED,0);
DBCC CHECKIDENT (BAQUETAS,RESEED,0);
DBCC CHECKIDENT (BOLETAS, RESEED, 0);
DBCC CHECKIDENT (VENTASENTRADAS, RESEED, 0)
DBCC CHECKIDENT (MESAS, RESEED, 0);
DBCC CHECKIDENT (EQUIPOS, RESEED, 0)
DBCC CHECKIDENT (ATRILES, RESEED, 0);
DBCC CHECKIDENT (MICROFONOS, RESEED, 0)
DBCC CHECKIDENT (GUITARRAS, RESEED, 0);
DBCC CHECKIDENT (RECLAMOS,RESEED,0);