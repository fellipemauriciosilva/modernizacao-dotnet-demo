import { ClienteForm } from './features/clientes/ClienteForm';
import { ClienteList } from './features/clientes/ClienteList';

function App() {
  return (
    <div>
      <h1>Cadastro de Cliente</h1>
      <ClienteForm />
      <ClienteList />
    </div>
  );
}

export default App;
