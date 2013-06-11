CREATE PROC p_incluir_aluno
	@rm int,
	@nome nvarchar(50),
	@curso nvarchar(50),
	@dataNasc datetime,
	@status int output
AS
BEGIN
	IF EXISTS(Select RM FROM TBAlunos WHERE RM = @rm)
		BEGIN
			UPDATE TBAlunos 
			SET Nome = @nome,
				Curso = @curso,
				DataNasc = @dataNasc
			where rm = @rm

			SET @status = 1
		END
	ELSE
		BEGIN
			INSERT INTO TBAlunos (RM,Nome,Curso,DataNasc)
			VALUES (@rm,@nome,@curso,@dataNasc)

			SET @status = 2
		END
END