import { render, screen, fireEvent } from '@testing-library/react';
import { ClienteForm } from './ClienteForm';

test('deve mostrar erro se nome estiver vazio', async () => {
  render(<ClienteForm />);
  fireEvent.click(screen.getByText(/salvar/i));
  expect(await screen.findByText(/obrigatório/i)).toBeInTheDocument();
});
