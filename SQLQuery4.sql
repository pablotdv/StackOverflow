SET NOCOUNT ON;
--crio uma tabela tempor�ria para simular a sua tabela
CREATE TABLE #formulas_table(
formula varchar(100),
A int, 
B int,
C int)
--insiro uns dados de amostra
insert into #formulas_table
select '(B/2)+ C' formula, 10 B,5 C,0 A
union all select '(B/1)+ C' formula, 10 B,5 C,0 A
union all select '(B/3)+ C' formula, 10 B,5 C,0 A

begin --esse � o trecho que voc� precisa
	--declaro um cursor com os dados da tabela de amostra
	--aqui voc� ir� substituir pelo seu select na sua tabela
	declare formulas cursor fast_forward for
	select formula
	from #formulas_table
	declare @formula varchar(100)

	--abre o cursor e atribiu o valor na vari�vel @formula
	OPEN formulas  
	FETCH NEXT FROM formulas   
	INTO @formula

	--percorro o cursor at� que n�o tenha mais dados
	while @@FETCH_STATUS = 0 
	BEGIN 
		--o exec pode ser usado para montar consultas concatenadas em uma string
		exec('select top 1 ' + @formula + ' from #formulas_table')

		--vai para o pr�ximo item do cursor
		FETCH NEXT FROM formulas   
		INTO @formula
	END

	--fecha e libera o cursor de mem�ria
	CLOSE formulas;  
	DEALLOCATE formulas; 
end --fim do trecho que voc� precisa

--dropa a tabela tempor�ria, pois s� precisei dela para montar o exemplo
drop table #formulas_table