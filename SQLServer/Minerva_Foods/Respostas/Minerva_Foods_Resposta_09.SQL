/*==========================================================================

	System...: Minerva_Foods
	Developer: Fernando Roberto Fernández
	Creation of a function that return an average ponderous.

==========================================================================*/

Use Minerva_Foods;

Go

/*========================================================================*/

Create Function dbo.Fct_Media_Ponderada
(
@Valor1 Decimal(18, 2),
@Peso1 Decimal(18, 2),
@Valor2 Decimal(18, 2),
@Peso2 Decimal(18, 2)
)
Returns Decimal(18, 2)
As
begin
  Declare @Media Decimal(18, 2);

  Select @Media = ((@Valor1 * @Peso1) + (@Valor2 * @Peso2)) / (@Peso1 + @Peso2);

  Return @Media;
end;

Go

/*========================================================================*/
