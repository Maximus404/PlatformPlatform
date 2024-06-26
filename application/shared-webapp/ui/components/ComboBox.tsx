import { ChevronDown } from "lucide-react";
import type React from "react";
import type { ComboBoxProps as AriaComboBoxProps, ListBoxItemProps, ValidationResult } from "react-aria-components";
import { ComboBox as AriaComboBox, ListBox } from "react-aria-components";
import { Button } from "./Button";
import { Description, FieldError, FieldGroup, Input, Label } from "./Field";
import type { DropdownSectionProps } from "./ListBox";
import { DropdownItem, DropdownSection } from "./ListBox";
import { Popover } from "./Popover";
import { composeTailwindRenderProps } from "./utils";

export interface ComboBoxProps<T extends object> extends Omit<AriaComboBoxProps<T>, "children"> {
  label?: string;
  description?: string | null;
  errorMessage?: string | ((validation: ValidationResult) => string);
  children: React.ReactNode | ((item: T) => React.ReactNode);
}

export function ComboBox<T extends object>({
  label,
  description,
  errorMessage,
  children,
  items,
  ...props
}: Readonly<ComboBoxProps<T>>) {
  return (
    <AriaComboBox {...props} className={composeTailwindRenderProps(props.className, "group flex flex-col gap-1")}>
      <Label>{label}</Label>
      <FieldGroup>
        <Input />
        <Button variant="icon" className="w-6 mr-1 rounded outline-offset-0 ">
          <ChevronDown aria-hidden className="w-4 h-4" />
        </Button>
      </FieldGroup>
      {description && <Description>{description}</Description>}
      <FieldError>{errorMessage}</FieldError>
      <Popover className="w-[--trigger-width]">
        <ListBox
          items={items}
          className="outline-0 p-1 max-h-[inherit] overflow-auto [clip-path:inset(0_0_0_0_round_.75rem)]"
        >
          {children}
        </ListBox>
      </Popover>
    </AriaComboBox>
  );
}

export function ComboBoxItem(props: Readonly<ListBoxItemProps>) {
  return <DropdownItem {...props} />;
}

export function ComboBoxSection<T extends object>(props: Readonly<DropdownSectionProps<T>>) {
  return <DropdownSection {...props} />;
}
