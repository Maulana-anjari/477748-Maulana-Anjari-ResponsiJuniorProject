CREATE OR REPLACE FUNCTION get_karyawan_data()
RETURNS TABLE (id_karyawan INTEGER, nama VARCHAR, id_dep VARCHAR, nama_dep VARCHAR) AS $$
BEGIN
	RETURN QUERY
	SELECT k.id_karyawan, k.nama, k.id_dep, d.nama_dep
	FROM karyawan k
	INNER JOIN departemen d ON k.id_dep = d.id_dep;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION insert_karyawan
(nama_dep_input CHARACTER VARYING, nama_karyawan_input CHARACTER VARYING)
RETURNS INTEGER AS $$
DECLARE
	dep_id CHARACTER VARYING;
BEGIN
	SELECT id_dep INTO dep_id FROM departemen WHERE nama_dep = nama_dep_input;
	INSERT INTO karyawan (id_dep, nama) VALUES (dep_id, nama_karyawan_input);
	RETURN 1;
EXCEPTION
	WHEN OTHERS THEN
		RETURN 0;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION delete_karyawan(id_karyawan_input INTEGER)
RETURNS INTEGER AS $$
BEGIN
	DELETE FROM karyawan WHERE id_karyawan = id_karyawan_input;
	return 1;
EXCEPTION
	WHEN OTHERS THEN
	RETURN 0;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION update_karyawan(
	id_karyawan_input INTEGER,
	nama_karyawan_input CHARACTER VARYING,
	id_dep_input CHARACTER VARYING
)
RETURNS INTEGER AS $$
DECLARE
	dep_id CHARACTER VARYING;
BEGIN
	SELECT id_dep INTO dep_id FROM departemen WHERE nama_dep = id_dep_input;
	UPDATE karyawan
	SET nama = nama_karyawan_input, id_dep = dep_id
	WHERE id_karyawan = id_karyawan_input;
	RETURN 1;
EXCEPTION
	WHEN OTHERS THEN
		RETURN 0;
END;
$$ LANGUAGE plpgsql;