

	DECLARE @CountExist int
	SELECT @CountExist = count(0) FROM MEMBER_ROLE WHERE @PID=4484 AND @RoleID='Admin'
	if(@CountExist =0)
	BEGIN
		INSERT INTO [dbo].MEMBER_ROLE
		(
		PID,
		RoleID,
		SemesterID
		)
		VALUES
		(
		'4484',
		'Admin',
		'sum17'
		)
	END
	