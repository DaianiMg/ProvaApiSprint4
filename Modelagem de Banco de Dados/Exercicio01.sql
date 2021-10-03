# 1 - Listar nome do dependente, idade do dependente, nome do cliente, 
#idade do cliente. para todos os clientes que possuam tp_cliente como 'FIDELIZADO'.
SELECT dependente.nome, dependente.idade, cliente.nome, cliente.idade FROM tipo_cliente
INNER JOIN cliente ON cliente.tp_cliente = tipo_cliente.id
INNER JOIN dependente ON cliente.id = dependente.id_cliente
WHERE tipo_cliente.descricao = 'FIDELIZADO';


#2 - Listar Nome e Id de todos os clientes que não possuam dependente.
SELECT cliente.nome, cliente.id FROM cliente
LEFT JOIN dependente ON cliente.id = dependente.id_cliente
WHERE dependente.id_cliente IS NULL;


#3 - Listar todos os dependentes que possuam um cliente que, em seu nome tenha a substring 'AR'.
# EX: Nesse caso seriam todos os dependentes da 'MARIA'.

SELECT dependente.* 
FROM cliente
INNER JOIN dependente ON cliente.id = dependente.id_cliente
WHERE cliente.nome LIKE '%AR%';
