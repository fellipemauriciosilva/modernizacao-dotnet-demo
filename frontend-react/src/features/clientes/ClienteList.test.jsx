import { render, screen } from '@testing-library/react';
import { ClienteList } from './ClienteList';

jest.mock('./clienteService', () => ({
  getClientes: () => Promise.resolve({ data: [{ nome: 'João' }] })
}));

test('deve exibir lista de clientes', async () => {
  render(<ClienteList />);
  expect(await screen.findByText('João')).toBeInTheDocument();
});
