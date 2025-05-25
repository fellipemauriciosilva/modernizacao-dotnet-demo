import { useState } from 'react';
import { salvarCliente } from './clienteService';
import * as yup from 'yup';
import { InputText } from '../../components/InputText';

const schema = yup.object().shape({
  nome: yup.string().required('Nome é obrigatório')
});

export function ClienteForm() {
  const [nome, setNome] = useState('');
  const [erro, setErro] = useState('');

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await schema.validate({ nome });
      await salvarCliente({ nome });
      alert('Cliente salvo!');
      setNome('');
    } catch (err) {
      setErro(err.message);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <InputText label="Nome" name="nome" value={nome} onChange={(e) => setNome(e.target.value)} />
      {erro && <p style={{ color: 'red' }}>{erro}</p>}
      <button type="submit">Salvar</button>
    </form>
  );
}
