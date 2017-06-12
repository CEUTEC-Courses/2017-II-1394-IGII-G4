/*CREATE TRIGGER ON_RUTA_CREATE ON ruta AFTER INSERT
AS
BEGIN
	declare @RutaID int
	declare @PuntoOrigenID int
	declare @PuntoDestinoID int
	select @RutaID = RutaID, @PuntoDestinoID = IDPuntoDestino, @PuntoOrigenID = IDPuntoOrigen from inserted
	insert into rutapunto (RutaID, PuntoID) VALUES (@RutaID, @PuntoOrigenID)
	insert into rutapunto (RutaID, PuntoID) VALUES (@RutaID, @PuntoDestinoID)
END*/

/*CREATE TRIGGER ON_RUTA_UPDATE ON ruta AFTER UPDATE
AS
BEGIN
	declare @UltimoOrigen int
	declare @UltimoDestino int
	declare @nuevoOrigen int
	declare @nuevoDestino int
	declare @RutaPuntoId int
	select @UltimoOrigen = IDPuntoOrigen, @UltimoDestino = IDPuntoDestino FROM deleted
	select @nuevoOrigen = IDPuntoOrigen, @nuevoDestino = IDPuntoDestino from inserted
	select @RutaPuntoId = RutaPuntoID from rutapunto WHERE PuntoID = @UltimoOrigen
	update rutapunto set PuntoID = @nuevoOrigen  WHERE RutaPuntoID = @RutaPuntoId
	select @RutaPuntoId = RutaPuntoID from rutapunto WHERE PuntoID = @UltimoDestino
	update rutapunto set PuntoID = @nuevoDestino  WHERE RutaPuntoID = @RutaPuntoId	
END*/

/*CREATE TRIGGER ON_RUTA_DELETE ON ruta AFTER DELETE
AS
BEGIN
	declare @RutaID int
	select @RutaID = RutaID from deleted
	delete FROM rutapunto WHERE RutaID = @RutaID
END*/