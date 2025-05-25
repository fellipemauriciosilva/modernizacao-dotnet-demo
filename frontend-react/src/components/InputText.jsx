export function InputText({ label, value, onChange, name }) {
  return (
    <div>
      <label>{label}</label>
      <input name={name} value={value} onChange={onChange} className="input" />
    </div>
  );
}
