import { useEffect, useState } from "react";

export default function Index() {
  const [dados, setDados] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5153/api/Usuario")
      .then((res) => res.json())
      .then((res) => setDados(res));
  }, []);

  return (
    <div>
      <h1>Lista de Usuários</h1>
      <table className="table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Nome</th>
            <th>Cpf</th>
            <th>Email</th>
            <th>Senha</th>
            <th>Telefone</th>
            <th>Destino</th>
          </tr>
        </thead>
        <tbody>
          {dados &&
            dados.map((usuario) => (
              <tr key={usuario.id}>
                <td>{usuario.id}</td>
                <td>{usuario.nome}</td>
                <td>{usuario.cpf}</td>
                <td>{usuario.email}</td>
                <td>{usuario.senha}</td>
                <td>{usuario.telefone}</td>
                <td>{usuario.destino}</td>
              </tr>
            ))}
        </tbody>
      </table>
    </div>
  );
}
