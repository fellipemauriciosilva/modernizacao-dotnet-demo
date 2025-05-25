import { useEffect, useState } from 'react';
import { getClientes } from './clienteService';

export function ClienteList() {
  const [clientes, setClientes] = useState([]);

  useEffect(() => {
    getClientes().then(res => setClientes(res.data));
  }, []);

  return (
    <div>
      <h2>Clientes</h2>
      <ul>
        {clientes.map((c, i) => <li key={i}>{c.nome}</li>)}
      </ul>
    </div>
  );
}
